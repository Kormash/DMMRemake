// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DMMRemake.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using DMMRemake;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\repos\DMMremake\DMMRemake\_Imports.razor"
using DMMRemake.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 301 "D:\repos\DMMremake\DMMRemake\Pages\Index.razor"
 
    bool HideCancel = true;
    List<Initiative> InitiativeList = new();
    string InitiativeName = "";
    int InitiativeRoll = 0;
    int InitiativeHP = 0;
    int Roll = 0;

    Random rand = new Random();

    List<Dice> d100List = new();
    List<Dice> d20List = new();
    List<Dice> d12List = new();
    List<Dice> d10List = new();
    List<Dice> d8List = new();
    List<Dice> d6List = new();
    List<Dice> d4List = new();

    int d100toRoll = 0;
    int d20toRoll = 0;
    int d12toRoll = 0;
    int d10toRoll = 0;
    int d8toRoll = 0;
    int d6toRoll = 0;
    int d4toRoll = 0;

    bool HideD100Count = true;
    bool HideD20Count = true;
    bool HideD12Count = true;
    bool HideD10Count = true;
    bool HideD8Count = true;
    bool HideD6Count = true;
    bool HideD4Count = true;

    bool CanEdit = false;

    DiceModel diceModel = new();

    public void AddD100()
    {
        d100toRoll++;
        HideD100Count = false;
    }
    public void SubtractD100()
    {
        if (d100toRoll > 0)
        {
            d100toRoll--;
        }
        if (d100toRoll == 0)
        {
            HideD100Count = true;
        }
    }
    public void AddD20()
    {
        d20toRoll++;
        HideD20Count = false;
    }
    public void SubtractD20()
    {
        if (d20toRoll > 0)
        {
            d20toRoll--;
        }
        if (d20toRoll == 0)
        {
            HideD20Count = true;
        }
    }
    public void AddD12()
    {
        d12toRoll++;
        HideD12Count = false;
    }
    public void SubtractD12()
    {
        if (d12toRoll > 0)
        {
            d12toRoll--;
        }
        if (d12toRoll == 0)
        {
            HideD12Count = true;
        }
    }
    public void AddD10()
    {
        d10toRoll++;
        HideD10Count = false;
    }
    public void SubtractD10()
    {
        if (d10toRoll > 0)
        {
            d10toRoll--;
        }
        if (d10toRoll == 0)
        {
            HideD10Count = true;
        }
    }
    public void AddD8()
    {
        d8toRoll++;
        HideD8Count = false;
    }
    public void SubtractD8()
    {
        if (d8toRoll > 0)
        {
            d8toRoll--;
        }
        if (d8toRoll == 0)
        {
            HideD8Count = true;
        }
    }
    public void AddD6()
    {
        d6toRoll++;
        HideD6Count = false;
    }
    public void SubtractD6()
    {
        if (d6toRoll > 0)
        {
            d6toRoll--;
        }
        if (d6toRoll == 0)
        {
            HideD6Count = true;
        }
    }
    public void AddD4()
    {
        d4toRoll++;
        HideD4Count = false;
    }
    public void SubtractD4()
    {
        if (d4toRoll > 0)
        {
            d4toRoll--;
        }
        if (d4toRoll == 0)
        {
            HideD4Count = true;
        }
    }
    public void RollDice()
    {
        if (d100toRoll != 0)
        {
            for(int i = 0; i < d100toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 100;
                d.DiceResult = rand.Next(1,101);
                d100List.Add(d);
            }
            HideCancel = false;
        }
        if (d20toRoll != 0)
        {
            for (int i = 0; i < d20toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 20;
                d.DiceResult = rand.Next(1, 21);
                d20List.Add(d);
            }
            HideCancel = false;
        }
        if (d12toRoll != 0)
        {
            for (int i = 0; i < d12toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 12;
                d.DiceResult = rand.Next(1, 13);
                d12List.Add(d);
            }
            HideCancel = false;
        }
        if (d10toRoll != 0)
        {
            for (int i = 0; i < d10toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 10;
                d.DiceResult = rand.Next(1, 11);
                d10List.Add(d);
            }
            HideCancel = false;
        }
        if (d8toRoll != 0)
        {
            for (int i = 0; i < d8toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 8;
                d.DiceResult = rand.Next(1, 9);
                d8List.Add(d);
            }
            HideCancel = false;
        }
        if (d6toRoll != 0)
        {
            for (int i = 0; i < d6toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 6;
                d.DiceResult = rand.Next(1, 7);
                d6List.Add(d);
            }
            HideCancel = false;
        }
        if (d4toRoll != 0)
        {
            for (int i = 0; i < d4toRoll; i++)
            {
                Dice d = new();
                d.DiceType = 4;
                d.DiceResult = rand.Next(1, 5);
                d4List.Add(d);
            }
            HideCancel = false;
        }

        HideD100Count = true;
        HideD20Count = true;
        HideD12Count = true;
        HideD10Count = true;
        HideD8Count = true;
        HideD6Count = true;
        HideD4Count = true;

        d100toRoll = 0;
        d20toRoll = 0;
        d12toRoll = 0;
        d10toRoll = 0;
        d8toRoll = 0;
        d6toRoll = 0;
        d4toRoll = 0;

        SortDice();
    }

    public void SortDice()
    {
        if (d100List.Any())
        {
            d100List = d100List.OrderByDescending(x => x.DiceResult).ToList();
        }
        if (d20List.Any())
        {
            d20List = d20List.OrderByDescending(x => x.DiceResult).ToList();
        }
        if (d12List.Any())
        {
            d12List = d12List.OrderByDescending(x => x.DiceResult).ToList();
        }
        if (d10List.Any())
        {
            d10List = d10List.OrderByDescending(x => x.DiceResult).ToList();
        }
        if (d8List.Any())
        {
            d8List = d8List.OrderByDescending(x => x.DiceResult).ToList();
        }
        if (d6List.Any())
        {
            d6List = d6List.OrderByDescending(x => x.DiceResult).ToList();
        }
        if (d4List.Any())
        {
            d4List = d4List.OrderByDescending(x => x.DiceResult).ToList();
        }
    }

    public void ClearDices()
    {
        HideCancel = true;
        d100List = new();
        d20List = new();
        d12List = new();
        d10List = new();
        d8List = new();
        d6List = new();
        d4List = new();
    }

    public void RemoveDice(Dice dice)
    {
        switch (dice.DiceType)
        {
            case 100:
                d100List.Remove(dice);
                break;
            case 20:
                d20List.Remove(dice);
                break;
            case 12:
                d12List.Remove(dice);
                break;
            case 10:
                d10List.Remove(dice);
                break;
            case 8:
                d8List.Remove(dice);
                break;
            case 6:
                d6List.Remove(dice);
                break;
            case 4:
                d4List.Remove(dice);
                break;
        }

        if (d100List.Count() == 0 && d20List.Count() == 0 && d12List.Count() == 0 && d10List.Count() == 0 && d8List.Count() == 0 && d6List.Count() == 0 && d4List.Count() == 0)
        {
            HideCancel = true;
        }

    }

    public void AddInitiative(int status)
    {
        if (InitiativeName != "")
        {
            Initiative i = new();
            i.Name = InitiativeName;
            i.Roll = InitiativeRoll;
            i.Status = status;
            i.IsCurrent = false;

            if (InitiativeList.Count == 0 || InitiativeList.First().IsCurrent == false)
            {
                InitiativeList.Add(i);
            }
            else
            {
                int index = 0;
                foreach (var initiative in InitiativeList)
                {
                    if (InitiativeList.Max(x => x.Roll) > i.Roll && InitiativeList.Min(x => x.Roll) < i.Roll)
                    {
                        index = InitiativeList.FindIndex(x => x == initiative);
                        if (initiative.Roll > i.Roll && (InitiativeList.Count() < index + 2 || InitiativeList[index + 1].Roll <= i.Roll))
                        {
                            index++;
                            break;
                        }
                    }
                    else
                    {
                        if (InitiativeList.Max(x => x.Roll) <= i.Roll && initiative.Roll == InitiativeList.Max(x => x.Roll))
                        {
                            index = InitiativeList.FindIndex(x => x == initiative);
                            break;
                        }
                        if (InitiativeList.Min(x => x.Roll) >= i.Roll && initiative.Roll == InitiativeList.Min(x => x.Roll))
                        {
                            index = InitiativeList.FindIndex(x => x == initiative) + 1;
                            break;
                        }
                    }

                }
                if (index < InitiativeList.Count && index != 0)
                {
                    InitiativeList.Insert(index, i);
                }
                else
                {
                    InitiativeList.Add(i);
                }

            }


            InitiativeName = "";
            InitiativeRoll = 0;
            InitiativeHP = 0;
        }
    }

    public void RemoveInitiative(Initiative i)
    {
        InitiativeList.Remove(i);
        if (i.IsCurrent == true && InitiativeList.Count > 0)
        {
            InitiativeList.First().IsCurrent = true;
        }
    }

    public void ChangeRoll(Initiative i, int newInitiative)
    {
        foreach (var ini in InitiativeList.Where(x => x == i))
        {
            ini.Roll = newInitiative;
        }
        Console.WriteLine("");
    }

    public void SortInitiative()
    {
        if (InitiativeList.Count > 0)
        {
            InitiativeList = InitiativeList.OrderBy(x => x.Roll).Reverse().ToList();
            foreach (var i in InitiativeList)
            {
                i.IsCurrent = false;
            }
            InitiativeList.First().IsCurrent = true;
        }

    }

    public void NextInitiative()
    {
        if (InitiativeList.Count > 0)
        {
            Initiative i = InitiativeList.First();
            InitiativeList.Remove(i);
            i.IsCurrent = false;
            InitiativeList.Add(i);
            InitiativeList.First().IsCurrent = true;
        }
    }

    public void ClearInitiative()
    {
        InitiativeList = new();
    }

    public class DiceModel
    {
        public int DiceType { get; set; }

        public int DiceNumber { get; set; }

        public int DiceSum { get; set; }

        public string ResultString { get; set; }
    }

    public class Dice
    {
        public int DiceType { get; set; }
        public int DiceResult { get; set; }
    }

    public class Initiative
    {
        public string Name { get; set; }
        public int Roll { get; set; }

        public int Status { get; set; }
        public bool IsCurrent { get; set; }


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
