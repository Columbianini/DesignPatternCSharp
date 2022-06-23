using System;

namespace PatternComposition_MenuComponent
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINNER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");

            MenuComponent allMenus = new Menu("ALL MENUS", "ALL menus combined");

            allMenus.add(pancakeHouseMenu);
            allMenus.add(dinerMenu);
            allMenus.add(cafeMenu);

            dinerMenu.add(new MenuItem("Pasta", "Spaghetti with Marianara Sauce, and a slice of sourdough bread", true, 3.89));
            dinerMenu.add(dessertMenu);

            dessertMenu.add(new MenuItem("Apple Pie", "Apple Pie with flakey crust, topped with vanilla ice cream", true, 1.59));

            Waitress waitress = new Waitress(allMenus);
            waitress.printMenu();
        }
    }
}
