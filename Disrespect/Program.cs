using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LeagueSharp;
using LeagueSharp.Common;

namespace Disrespect
{
    class Program
    {
        public static Menu Config;

        private static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += OnStart;
        }

        private static void OnStart(EventArgs args)
        {
            Config = new Menu("Disrespect", "Disrespect", true);
            Config.AddItem(new MenuItem("laughon", "Laugh").SetValue(true));
            Config.AddItem(new MenuItem("jokeon", "Joke").SetValue(true));
            // Config.AddItem(new MenuItem("danceon", "Dance").SetValue(true));
            Config.AddItem(new MenuItem("taunton", "Taunt").SetValue(true));
            Config.AddItem(new MenuItem("keybind", "Active").SetValue(new KeyBind('t', KeyBindType.Press)));


            Config.AddItem(new MenuItem("sep", ""));
            Config.AddItem(new MenuItem("lk", "Input"));
            Config.AddItem(new MenuItem("vers", "2.0.0.0"));

            Config.AddToMainMenu();

            Game.OnNotify += GameEvents;
        }

        private static void GameEvents(GameNotifyEventArgs args)
        {
            if (args.EventId == GameEventId.OnAcquireBlueBuffFromNeutral ||
                args.EventId == GameEventId.OnAcquireRedBuffFromNeutral || 
                args.EventId == GameEventId.OnCastHeal ||
                args.EventId == GameEventId.OnChampionDie ||
                args.EventId == GameEventId.OnChampionKill ||
                args.EventId == GameEventId.OnChampionDoubleKill ||
                args.EventId == GameEventId.OnChampionPentaKill ||
                args.EventId == GameEventId.OnChampionQuadraKill ||
                args.EventId == GameEventId.OnChampionSingleKill ||
                args.EventId == GameEventId.OnChampionTripleKill ||
                args.EventId == GameEventId.OnCriticalStrike ||
                args.EventId == GameEventId.OnDamageGiven ||
                args.EventId == GameEventId.OnDamageTaken ||
                args.EventId == GameEventId.OnDeathAssist ||
                args.EventId == GameEventId.OnDie ||
                args.EventId == GameEventId.OnEndGame ||
                args.EventId == GameEventId.OnFirstBlood ||
                args.EventId == GameEventId.OnGameStart ||
                args.EventId == GameEventId.OnGoldEarned ||
                args.EventId == GameEventId.OnHeal ||
                args.EventId == GameEventId.OnItemPurchased ||
                args.EventId == GameEventId.OnKill ||
                args.EventId == GameEventId.OnKillDragon ||
                args.EventId == GameEventId.OnKillDragonSteal ||
                args.EventId == GameEventId.OnKillingSpree ||
                args.EventId == GameEventId.OnKillWard ||
                args.EventId == GameEventId.OnKillWorm ||
                args.EventId == GameEventId.OnMinionKill ||
                args.EventId == GameEventId.OnPlaceWard ||
                args.EventId == GameEventId.OnTurretDamage ||
                args.EventId == GameEventId.OnTurretDie ||
                args.EventId == GameEventId.OnTurretKill)
            {
                if (Config.Item("laughon").GetValue<bool>() == true)
                {
                    Game.Say("/laugh");
                    Console.WriteLine("Laugh");
                }

                if (Config.Item("jokeon").GetValue<bool>() == true)
                {
                    Game.Say("/joke");
                    Console.WriteLine("Joke");
                }

                if (Config.Item("taunton").GetValue<bool>() == true)
                {
                    Game.Say("/taunt");
                    Console.WriteLine("Taunt");
                }
            }
        }

        private static void Laugh()
        {
            if (Config.Item("laughon").GetValue<bool>() == true)
            {
                Game.Say("/laugh");
                Console.WriteLine("Laugh");
            }       
        }
    }
}
