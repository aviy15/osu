// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using JetBrains.Annotations;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Game.Tournament.Models;

namespace osu.Game.Tournament.Components
{
    public class DrawableTeamTitle : TournamentSpriteTextWithBackground
    {
        private readonly TournamentTeam team;

        [UsedImplicitly]
        private Bindable<string> acronym;

        public DrawableTeamTitle(TournamentTeam team)
        {
            this.team = team;
        }

        [BackgroundDependencyLoader]
        private void load()
        {
            if (team == null) return;

            (acronym = team.Acronym.GetBoundCopy()).BindValueChanged(acronym => Text.Text = team?.FullName.Value ?? string.Empty, true);
        }
    }
}
