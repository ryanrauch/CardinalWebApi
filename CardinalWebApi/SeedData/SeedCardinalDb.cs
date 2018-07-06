using CardinalWebApi.Models;
using CardinalWebApiLibrary.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardinalWebApi.SeedData
{
    public class SeedCardinalDb
    {
        private CardinalDbContext _context { get; set; }

        public async Task SeedData(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<CardinalDbContext>();

            if(_context.Employees.Count() == 0)
            {
                var ryan = new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Active = true,
                    FirstName = "Ryan",
                    LastName = "Rauch",
                    PinCode = "4767"
                };
                await _context.Employees.AddAsync(ryan);
                var ivan = new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Active = true,
                    FirstName = "Ivan",
                    LastName = "Vujosevic",
                    PinCode = "4768"
                };
                await _context.Employees.AddAsync(ivan);
                var matt = new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Active = true,
                    FirstName = "Matt",
                    LastName = "Reinhart",
                    PinCode = "2444"
                };
                await _context.Employees.AddAsync(matt);
                var kaleigh = new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Active = true,
                    FirstName = "Kaleigh",
                    LastName = "McBride",
                    PinCode = "2445"
                };
                await _context.Employees.AddAsync(kaleigh);
                var cayley = new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Active = true,
                    FirstName = "Cayley",
                    LastName = "Adams",
                    PinCode = "2446"
                };
                await _context.Employees.AddAsync(cayley);
                var heidi = new Employee()
                {
                    EmployeeId = Guid.NewGuid(),
                    Active = true,
                    FirstName = "Heidi",
                    LastName = "Werstler",
                    PinCode = "2447"
                };
                await _context.Employees.AddAsync(heidi);
                await _context.SaveChangesAsync();
            }

            if (_context.Items.Count() == 0 
                && _context.ItemGroups.Count() == 0)
            {
                //itemgroups
                var wellDrinks = new ItemGroup()
                {
                    ItemGroupId = Guid.NewGuid(),
                    Description = "Well Drinks"
                };
                await _context.ItemGroups.AddAsync(wellDrinks);
                var premiumLiquor = new ItemGroup()
                {
                    ItemGroupId = Guid.NewGuid(),
                    Description = "Premium Liquor"
                };
                await _context.ItemGroups.AddAsync(premiumLiquor);
                var domesticBeer = new ItemGroup()
                {
                    ItemGroupId = Guid.NewGuid(),
                    Description = "Domestic Beer"
                };
                await _context.ItemGroups.AddAsync(domesticBeer);
                var importBeer = new ItemGroup()
                {
                    ItemGroupId = Guid.NewGuid(),
                    Description = "Imported Beer"
                };
                await _context.ItemGroups.AddAsync(importBeer);
                var shots = new ItemGroup()
                {
                    ItemGroupId = Guid.NewGuid(),
                    Description = "Shots"
                };
                await _context.ItemGroups.AddAsync(shots);
                var quick = new ItemGroup()
                {
                    ItemGroupId = Guid.NewGuid(),
                    Description = "Quick"
                };
                await _context.ItemGroups.AddAsync(quick);
                //premium-drinks
                var p = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Jameson",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p);
                var p2 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Deep Eddy Lemon",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p2);
                var p3 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Deep Eddy RubyRed",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p3);
                var p4 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Titos",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p4);
                var p5 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Grey Goose",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p5);
                var p6 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Patron",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p6);
                var p7 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Don Julio",
                    Price = 10.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p7);
                var p8 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "1942",
                    Price = 25.00M,
                    ItemGroupId = premiumLiquor.ItemGroupId
                };
                await _context.Items.AddAsync(p8);

                //well drinks
                var item = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Well Whiskey",
                    Price = 8.00M,
                    ItemGroupId = wellDrinks.ItemGroupId
                };
                await _context.Items.AddAsync(item);
                var item2 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Well Vodka",
                    Price = 8.00M,
                    ItemGroupId = wellDrinks.ItemGroupId
                };
                await _context.Items.AddAsync(item2);
                var item3 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Well Gin",
                    Price = 8.00M,
                    ItemGroupId = wellDrinks.ItemGroupId
                };
                await _context.Items.AddAsync(item3);
                var item4 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Well Tequila",
                    Price = 8.00M,
                    ItemGroupId = wellDrinks.ItemGroupId
                };
                await _context.Items.AddAsync(item4);

                //domestic beer
                var item5 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Bud Light",
                    Price = 7.00M,
                    ItemGroupId = domesticBeer.ItemGroupId
                };
                await _context.Items.AddAsync(item5);
                var item6 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Coors Light",
                    Price = 7.00M,
                    ItemGroupId = domesticBeer.ItemGroupId
                };
                await _context.Items.AddAsync(item6);
                var item7 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Miller Light",
                    Price = 7.00M,
                    ItemGroupId = domesticBeer.ItemGroupId
                };
                await _context.Items.AddAsync(item7);

                //import beer
                var item8 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Dos Equis",
                    Price = 7.00M,
                    ItemGroupId = importBeer.ItemGroupId
                };
                await _context.Items.AddAsync(item8);
                var item9 = new Item()
                {
                    ItemId = Guid.NewGuid(),
                    Description = "Corona",
                    Price = 7.00M,
                    ItemGroupId = importBeer.ItemGroupId
                };
                await _context.Items.AddAsync(item9);
                await _context.SaveChangesAsync();

                var rnd = new RandomNameGenerator();
                List<String> drinkNames = rnd.DrinkNames;
                foreach(string d in drinkNames)
                {
                    var dr = new Item()
                    {
                        ItemId = Guid.NewGuid(),
                        Description = d,
                        Price = 7.50M,
                        ItemGroupId = quick.ItemGroupId
                    };
                    await _context.Items.AddAsync(dr);
                }
            }

            if (_context.Tabs.Count() == 0)
            {
                var rnd = new RandomNameGenerator();
                List<Item> items = _context.Items.ToList();
                for(int i = 0; i < 25; ++i)
                {
                    var tab = new Tab()
                    {
                        TabId = Guid.NewGuid(),
                        FirstName = rnd.GetFirstName(),
                        LastName = rnd.GetLastName(),
                        TimestampOpened = DateTime.Now.AddMinutes(0 - (i * 5)),
                        CurrentState = CardinalWebApiLibrary.TabState.Opened
                    };
                    await _context.Tabs.AddAsync(tab);
                    //await _context.SaveChangesAsync();

                    
                    var tabitem = new TabItem()
                    {
                        TabId = tab.TabId,
                        Quantity = Math.Max(1, i % 5),
                        ItemId = items[i % (items.Count - 1)].ItemId
                    };
                    await _context.TabItems.AddAsync(tabitem);

                    if (i % 2 == 0)
                    {
                        var tabitem2 = new TabItem()
                        {
                            TabId = tab.TabId,
                            Quantity = 1,
                            ItemId = items[(i + 1) % (items.Count - 1)].ItemId
                        };
                        await _context.TabItems.AddAsync(tabitem2);
                    }
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
