using UnityEngine;

namespace Scaffold {

    public static class GameGameDomain {

        public static void NewGame(GameBusinessContext ctx) {

            var config = ctx.templateInfraContext.Config_Get();

            // Game
            var game = ctx.gameEntity;
            game.fsmComponent.Gaming_Enter();

            // Role
            var player = ctx.playerEntity;

            // - Owner
            var owner = GameRoleDomain.Spawn(ctx,
                                             config.ownerRoleTypeID,
                                             new Vector2(0, 0));
            player.ownerRoleEntityID = owner.entityID;

            // - NPC
            // foreach (var npc in mapTM.roleSpawnArr) {
            //     GameRoleDomain.Spawn(ctx,
            //                          npc.typeID,
            //                          npc.pos);
            // }

            // Camera

            // UI

            // Cursor

        }

        public static void ExitGame(GameBusinessContext ctx) {
            // Game
            var game = ctx.gameEntity;
            game.fsmComponent.NotInGame_Enter();

            // Role
            int roleLen = ctx.roleRepo.TakeAll(out var roles);
            for (int i = 0; i < roleLen; i++) {
                var role = roles[i];
                GameRoleDomain.UnSpawn(ctx, role);
            }

            // UI
        }

    }
}