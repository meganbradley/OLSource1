---
title: "Strings Element"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Strings element (VSCT XML schema)"
  - "VSCT XML schema elements, Strings"
ms.assetid: 23a42074-a689-481d-824f-b43aa448f266
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Strings Element
The Strings element must contain at least a **ButtonText** child element. All other child elements are optional. Invalid XML characters such as ‘&’ and ‘<’ must be coded as entities (‘&amp;’ and ‘&lt;’ and so on).  
  
 An ampersand in the text string specifies the keyboard shortcut for the command.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|language|Optional. Language=".".|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|ButtonText|This field and the five following text fields in a command definition let you specify the text that appears in various menus. By default, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> field appears in menu controllers. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> field also becomes the default if the other text fields are blank. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> field cannot be blank even if the other text fields are specified.|  
|ToolTipText|The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> field specifies the text that appears in the tooltip for a menu item.\<br />\<br /> If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> field is blank, the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field is used.|  
|MenuText|The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> field specifies the text that is displayed for a command if it is on the main menu, a toolbar, in a shortcut menu, or in a submenu. If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> field is blank, the integrated development environment (IDE) uses the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> field. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> field can also be used for localization.\<br />\<br /> For shortcut menus, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> field is the name that is displayed in the Shortcut Menus toolbar, which enables customization of shortcut menus in the IDE. Therefore, be specific in what you name your shortcut menu; for example, use "Widget Package Shortcut Menu" instead of "Shortcut".\<br />\<br /> If the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> field is not specified, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field is used.|  
|CommandName|The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> field specifies the text that appears in the keyboard category in the **Commands** tab in the **Customize** dialog box (available by clicking **Customize** on the **Tools** menu).|  
|CanonicalName|The English <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> field specifies the name of the command in English text that can be entered in the **Command** window to execute the menu item. The IDE strips out any characters that are not letters, digits, underscores, or embedded periods. This text is then concatenated to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> field to define the command. For example, **New Project** on the **File** menu becomes the command, File.NewProject.\<br />\<br /> If the English <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> field is not specified, the IDE uses the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> field, and strips out all except letters, digits, underscores, and embedded periods. For example, the Button Text "&Define Commands..." becomes DefineCommands, where the ampersand, the space, and the ellipsis are removed.\<br />\<br /> If the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> flag is specified and the text of the command is changed, the corresponding command recognized by the **Command** window does not change; it remains the canonical form of the original <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> or English <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> fields.|  
|LocCanonicalName|The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> field behaves identically to the English <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> field but enables localized command text to be specified. Both canonical fields can be specified. Because the IDE just parses text entered in the **Command** window and associates it with a command, both English and non-English text can be associated with the same command.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Button](../vs140/button-element.md)|Defines an element that the user can interact with.|  
|[Menu](../vs140/menu-element.md)|Defines a single menu item.|  
|[Combo](../vs140/combo-element.md)|Defines commands that appear in a combo box.|  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)