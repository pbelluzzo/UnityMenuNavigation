# UnityMenuNavigation
## Simple Framework for creating menus in Unity

Basically, this package will help you:

> - Navigate through menu screens;
> - Stack PopUps without problem;
> - Implement screens with different tabs;

### Get Started

For you to get started, you just need to create a UINavigationManager in your scene and set your MenuScreens. You can use the MenuScreen class to define your screens, or extend it to your own classes. **Menu Screens should be always active in the hierarchy, and they should always have a child that contains all the content of the screen.** All the navigation can be handled through the button classes included in the package, but you can also do it by code. 

Check the DemoScene to test the implementation and see how things are set up.

### Classes

**CloseButton -** Closes the active screen;

**LoadSceneButton -** Load a Scene by index;

**MenuScreen -** Defines a screen. Must always be active in the hierarchy and have a child that contains all the content of the screen;

**MenuSystemDebugger -** Handles debug;

**NavigationButton -** Navigates to a MenuScreen through an UINavigationManager;

**SwitchTabButton -** Switches the active tab of a screen through the TabWindowController;

**TabWindowController -** Controls the navigation between tabs for screens with multiple tabs;

**UINavigationManager -** Controls the navigation between MenuScreens;
