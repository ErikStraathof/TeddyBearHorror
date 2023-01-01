using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum MenuType
{
    StartupMenu,
    MainMenu,
    PauseMenu,
    SettingsMenu,
    CreditsMenu
}

public class MenuManager : MonoBehaviour
{
    private MenuController activeMenu = null;
    private List<MenuController> menus;

    void Awake()
    {
        menus = GetComponentsInChildren<MenuController>().ToList();

        //First set every menu to inactive
        foreach (MenuController menuController in menus)
        {
            menuController.gameObject.SetActive(false);
        }

        //Activate the startup menu
        SwitchMenu(MenuType.StartupMenu);
    }

    public void SwitchMenu(MenuType menuType)
    {
        MenuController menu = menus.Find(m => m.type == menuType);

        if (activeMenu != null)
        {
            activeMenu.gameObject.SetActive(false);
        }

        if (menu != null)
        {
            menu.gameObject.SetActive(true);
            activeMenu = menu;
        }
    }
}
