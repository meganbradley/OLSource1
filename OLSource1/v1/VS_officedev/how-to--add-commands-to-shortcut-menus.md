---
title: "How to: Add Commands to Shortcut Menus"
ms.custom: na
ms.date: "08/09/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Office menus, creating"
  - "Office development in Visual Studio, context menus"
ms.assetid: 9a848817-db11-4294-8f6f-9181ab87aadd
caps.latest.revision: 22
ms.author: "normesta"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Add Commands to Shortcut Menus
  This topic demonstrates how to add commands to a shortcut menu in an Office application by using an VSTO Add-in.  
  
 [!INCLUDE[appliesto_all](../VS_officedev/includes/appliesto_all_md.md)]  
  
### To add commands to shortcut menus in Office  
  
1.  Add a **Ribbon XML** item to a document-level or VSTO Add-in project. For more information, see [How to: Get Started Customizing the Ribbon](../VS_officedev/how-to--get-started-customizing-the-ribbon.md). In  
  
2.  **Solution Explorer**, select **ThisAddin.cs** or **ThisAddin.vb**.  
  
3.  On the menu bar, choose **View**, **Code**.  
  
     The **ThisAddin** class file opens in the Code Editor.  
  
4.  Add the following code to the **ThisAddin** class. This code overrides the CreateRibbonExtensibilityObject method and returns the Ribbon XML class to the Office application.  
  
     [!code[Trin_WordAddIn_Menus#1](../VS_officedev/codesnippet/CSharp/how-to--add-commands-to-shortcut-menus_1.cs)]
[!code[Trin_WordAddIn_Menus#1](../VS_officedev/codesnippet/VisualBasic/how-to--add-commands-to-shortcut-menus_1.vb)]  
  
5.  In **Solution Explorer**, select the Ribbon XML file. By default, the Ribbon XML file is named Ribbon1.xml.  
  
6.  On the menu bar, choose **View**, **Code**.  
  
     The Ribbon xml file opens in the Code Editor.  
  
7.  In the Code Editor, add XML that describes the shortcut menu and the control that you want to add to the shortcut menu.  
  
     The following example adds a button, a menu, and a gallery control to the shortcut menu for a word document. The control ID of this shortcut menu is ContextMenuText. For a complete list of Office 2010 shortcut control ID’s, see [Office 2010 Help Files: Office Fluent User Interface Control Identifiers](http://go.microsoft.com/fwlink/?LinkID=181052).  
  
    ```  
    <?xml version="1.0" encoding="UTF-8"?>  
    <customUI xmlns="http://schemas.microsoft.com/office/2009/07/customui">  
      <contextMenus>  
        <contextMenu idMso="ContextMenuText">  
          <button id="MyButton" label="My Button" insertBeforeMso="HyperlinkInsert" onAction="GetButtonID" />  
          <menu id="MySubMenu" label="My Submenu" >  
            <button id="MyButton2" label="Button on submenu" />  
          </menu>  
          <gallery id="galleryOne" label="My Gallery">  
            <item id="item1" imageMso="HappyFace" />  
            <item id="item2" imageMso="HappyFace" />  
            <item id="item3" imageMso="HappyFace" />  
            <item id="item4" imageMso="HappyFace" />  
          </gallery>  
        </contextMenu>  
      </contextMenus>  
    </customUI>  
    ```  
  
8.  In **Solution Explorer**, choose **MyRibbon.cs** or **MyRibbon.vb**.  
  
9. Add the a callback method to the `Ribbon1` class for each control that you want to handle.  
  
     The following callback method handles the **My Button** button. This code adds a string to the active document at the current location of the curser.  
  
     [!code[Trin_WordAddIn_Menus#2](../VS_officedev/codesnippet/VisualBasic/how-to--add-commands-to-shortcut-menus_2.vb)]
[!code[Trin_WordAddIn_Menus#2](../VS_officedev/codesnippet/CSharp/how-to--add-commands-to-shortcut-menus_2.cs)]  
  
## See Also  
 [Office UI Customization](../VS_officedev/office-ui-customization.md)   
 [Walkthrough: Creating Shortcut Menus for Bookmarks](../VS_officedev/walkthrough--creating-shortcut-menus-for-bookmarks.md)   
 [Optional Parameters in Office Solutions](../VS_officedev/optional-parameters-in-office-solutions.md)   
 [Customizing Context Menus in Office 2010](http://go.microsoft.com/fwlink/?LinkId=182186)  
  
  