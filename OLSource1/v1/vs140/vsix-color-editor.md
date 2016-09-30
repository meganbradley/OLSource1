---
title: "VSIX Color Editor"
ms.custom: na
ms.date: "09/21/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 70879c5d-e0f0-4845-993c-2f4229869706
caps.latest.revision: 9
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# VSIX Color Editor
The Visual Studio Extension Color Editor tool can create and edit custom colors for Visual Studio. The tool can also generate theme resource keys so that the colors can be used in code. This tool is useful for making colors for a Visual Studio extension that supports theming. This tool can open .pkgdef and .xml files. Visual Studio themes (.vstheme files) can be used with the Visual Studio Extension Color Editor by changing the file extension to .xml. Additionally, .vstheme files can be imported into a current .xml file.  
  
 ![VSIX Color Editor Hero](../vs140/media/vsix-color-editor-hero.png "VSIX Color Editor Hero")  
  
 **Package definition files**  
  
 Package definition (.pkgdef) files are the files that define themes. The colors themselves are stored in theme color .xml files, which are compiled into a .pkgdef file. The .pkgdef files are deployed to Visual Studio searchable locations, processed at runtime, and merged together to define themes.  
  
 **Color tokens**  
  
 A color token is made up of four elements:  
  
-   **Category name:** A logical grouping for a set of colors. Use an existing category name if there are already colors that are specific to the desired UI element, or group of UI elements.  
  
-   **Token name:** A descriptive name for the color token and token sets. Sets include background and foreground (text) token names as well as all their states, and these should be named so that it is easy to identify the pairs and the states that they apply to.  
  
-   **Color values (or hues):** Needed for each colored theme. Always create background and text color values in pairs. Colors are paired for background/foreground so that the text (foreground) color is always readable against the background color on which it is drawn. These colors are linked and will be used together in the UI. If the background is not intended for use with text, do not define a foreground color.  
  
-   **System color name:** For use in high-contrast displays.  
  
## How to use the tool  
 As much as possible, and where appropriate, existing Visual Studio colors should be reused instead of making new ones. However, for cases where no appropriate colors are defined, custom colors should be created to keep an extension theming compatible.  
  
 **Creating new color tokens**  
  
 To create custom colors using the Visual Studio Extension Color Editor, follow these steps:  
  
1.  Determine the category and token names for the new color tokens.  
  
2.  Choose the hues that the UI element will use for each theme and the system color for High Contrast.  
  
3.  Use the color editor to create new color tokens.  
  
4.  Use the colors in a Visual Studio extension.  
  
5.  Test the changes in Visual Studio.  
  
 **Step 1: Determine the category and token names for the new color tokens.**  
  
 The preferred naming scheme for a VSColor is **[Category] [UI type] [State]**. Do not use the word “color” in VSColor names, as it is redundant.  
  
 Category names provide logical groupings, and should be defined as narrowly as possible. For example, the name of a single tool window could be a category name, but the name of an entire business unit or project team is not. Grouping entries into categories helps prevent confusion between colors with the same name.  
  
 A token name must clearly indicate the element type and the situations, or “state,” for which the color will be applied. For example, an active data tip’s **[UI type]** could be named “**DataTip**” and the **[State]** could be named “**Active**,” resulting in a color name of “**DataTipActive**.” Since data tips have text, both a foreground and a background color need to be defined. By using a background/foreground pairing, the color editor will automatically create the colors “**DataTipActive**” for the background and “**DataTipActiveText**” for the foreground.  
  
 If the piece of UI has only one state, the **[State]** part of the name can be omitted. For example, if a search box has a border and there is no state change that would affect the border’s color, then the name for the border’s color token can simply be called “**SearchBoxBorder**.”  
  
 Some common state names include:  
  
-   Active  
  
-   Inactive  
  
-   MouseOver  
  
-   MouseDown  
  
-   Selected  
  
-   Focused  
  
 Examples of a few token names for parts of a list item control:  
  
-   ListItem  
  
-   ListItemBorder  
  
-   ListItemMouseOver  
  
-   ListItemMouseOverBorder  
  
-   ListItemSelected  
  
-   ListItemSelectedBorder  
  
-   ListItemDisabled  
  
-   ListItemDisabledBorder  
  
 **Step 2: Choose the hues that the UI element will use for each theme and the system color for High Contrast.**  
  
 When choosing custom colors for UI, select a similar existing UI element, and use its colors as a base. The colors for in-the-box UI elements have undergone review and testing, so they will look appropriate and behave correctly in all themes.  
  
 **Step 3: Use the color editor to create new color tokens.**  
  
 Launch the color editor and open or create a new custom theme colors .xml file. Select **Edit > New Color** from the menu. This opens a dialog for specifying the category and one or more names for color entries within that category:  
  
 ![VSIX Color Editor New Color](../vs140/media/vsix-color-editor-new-color.png "VSIX Color Editor New Color")  
  
 Select an existing category, or select **New Category** to create a new category. Another dialog will open, creating a new category name:  
  
 ![VSIX Color Editor New Category](../vs140/media/vsix-color-editor-new-category.png "VSIX Color Editor New Category")  
  
 The new category will then become available in the **New Color** category drop-down menu. After choosing a category, enter one name per line for each new color token and select “Create” when finished:  
  
 ![VSIX Color Editor New Color Filled](../vs140/media/vsix-color-editor-new-color-filled.png "VSIX Color Editor New Color Filled")  
  
 The color values are shown in background/foreground pairs, with “None” indicating that the color has not been defined. Note: if a color does not have a text color/background color pair, then only the background needs to be defined.  
  
 ![VSIX Color Editor Color Values](../vs140/media/vsix-color-editor-color-values.png "VSIX Color Editor Color Values")  
  
 To edit a color token, select a color entry for the theme (column) of that token. Add the color value by either typing a hex color value in 8-digit ARGB format, entering a system color name into the cell, or using the drop-down menu to select the desired color via a set of color sliders or a list of system colors.  
  
 ![VSIX Color Editor Edit Color](../vs140/media/vsix-color-editor-edit-color.png "VSIX Color Editor Edit Color")  
  
 ![VSIX Color Editor Background](../vs140/media/vsix-color-editor-background.png "VSIX Color Editor Background")  
  
 For components that do not need to display text, enter only one color value: the background color. Otherwise, enter values for both background and text color, separated by a forward slash.  
  
 When entering values for High Contrast, enter valid Windows system color names. Do not enter hardcoded ARGB values. You can view a list of valid system color names by selecting “Background: System” or “Foreground: System” from the color value drop-down menus. When creating elements that have text components, use the correct background/text system color pair or the text might be unreadable.  
  
 When you finish creating, setting, and editing the color tokens, save them into the desired .xml or .pkgdef format. Color tokens with neither a background nor a foreground set will be saved as empty colors in .xml format, but discarded in .pkgdef format. A dialog will warn you of potential color loss if you attempt to save empty colors to a .pkgdef file.  
  
 **Step 4: Use the colors in a Visual Studio extension.**  
  
 After defining the new color tokens, include the .pkgdef in the project file with “Build Action” set to “Content,” and “Include in VSIX” set to “True.”  
  
 ![VSIX Color Editor pkgdef](../vs140/media/vsix-color-editor-pkgdef.png "VSIX Color Editor pkgdef")  
  
 In the Visual Studio Extension Color Editor, choose File > View Resource Code to view code that is used for accessing the custom colors in WPF-based UI.  
  
 ![VSIX Color Editor Resource Code Viewer](../vs140/media/vsix-color-editor-resource-code-viewer.png "VSIX Color Editor Resource Code Viewer")  
  
 Include this code in a static class in the project. A reference to **Microsoft.VisualStudio.Shell.\<VSVersion>.0.dll** needs to be added to the project to use the **ThemeResourceKey** type.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This enables access to the colors in XAML code and allows the UI to respond to theme changes.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Step 5: Test the changes in Visual Studio.**  
  
 The color editor can temporarily apply color tokens to the running instances of Visual Studio to view live changes to colors without rebuilding the extension package. To do so, click the “Apply this theme to running Visual Studio windows” button located on the header of each theme column. This temporary theme will go away when the VSIX Color Editor is closed.  
  
 ![VSIX Color Editor Apply](../vs140/media/vsix-color-editor-apply.png "VSIX Color Editor Apply")  
  
 To make the changes permanent, rebuild and redeploy the Visual Studio extension after adding the new colors to the .pkgdef file and writing the code that will use those colors. Rebuilding the Visual Studio extension will merge the registry values for the new colors into the rest of the themes. Then relaunch Visual Studio, view the UI, and verify that the new colors appear as expected.  
  
## Notes  
 This tool is intended to be used for creating custom colors for the preexisting Visual Studio themes, or for editing the colors of a custom Visual Studio theme. To create complete custom Visual Studio themes, download the [Visual Studio Color Theme Editor extension](http://visualstudiogallery.msdn.microsoft.com/6f4b51b6-5c6b-4a81-9cb5-f2daa560430b) from the Visual Studio Extensions Gallery.  
  
## Sample Output  
 **XML color output**  
  
 The .xml file generated by the tool will be similar to this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **PKGDEF color output**  
  
 The .pkgdef file generated by the tool will be similar to this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **C# resource keys wrapper**  
  
 The color resource keys generated by the tool will be similar to this:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **WPF resource dictionary wrapper**  
  
 The color **ResourceDictionary** keys generated by the tool will be similar to this:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>