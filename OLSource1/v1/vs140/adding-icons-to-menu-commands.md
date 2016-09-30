---
title: "Adding Icons to Menu Commands"
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
  - "icons [Visual Studio], adding to toolbars"
  - "toolbars [Visual Studio], adding icons to commands"
  - "commands [Visual Studio], adding icons"
ms.assetid: 362a0c7e-5729-4297-a83f-1aba1a37fd44
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding Icons to Menu Commands
Commands can appear on both menus and toolbars. On toolbars, it is common for a command to be displayed with just an icon (to save space) while on menus a command typically appears with both an icon and text.  
  
 Icons are 16 pixels wide by 16 pixels high and can be either 8-bit color depth (256 colors) or 32-bit color depth (true color). 32-bit color icons are preferred. Icons are typically arranged in a single horizontal row in a single bitmap, although multiple bitmaps are allowed. This bitmap is declared in the .vsct file along with the individual icons available in the bitmap. See the reference for the [\<Bitmaps> Section](../vs140/bitmaps-element.md) for more details.  
  
## Adding an Icon to a Command  
 The following procedure assumes that you have an existing VSPackage project with a menu command. To find out how to do this, see [Creating a VSPackage with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md).  
  
1.  Create a bitmap with a color depth of 32-bits. An icon is always 16 x 16 so this bitmap must be 16 pixels high and a multiple of 16 pixels wide.  
  
     Each icon is placed on the bitmap next to each other in a single row. Use the alpha channel to indicate places of transparency in each icon.  
  
     If you use an 8-bit color depth, use magenta, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, as the transparency. However, 32-bit color icons are preferred.  
  
2.  Copy the icon file to the Resources directory in your VSPackage project. In the Solution Explorer, add the icon to the project. (Select Resources, and on the context menu click Add, then Existing Item, and select your icon file.)  
  
3.  Open the .vsct file in the editor.  
  
4.  Add a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element with a name of **testIcon**. Create a GUID (**Tools / Create GUID**, then select **Registry Format** and click Copy) and paste it into the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute. The result should look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  Add an <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for the icon. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute is the icon's ID, and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> indicates its position on the strip, if any. If there is just one icon, add 1. The result should look like this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
6.  Create a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> section of the .vsct file to represent the bitmap containing the icons.  
  
    -   Set the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> value to the name of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element you created in the previous step.  
  
    -   Set the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> value to the relative path of the bitmap file (in this case **Resources\\<icon file name\>**.  
  
    -   Set the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value to the IDSymbol you created earlier. This attribute specifies a comma-delimited list of the icons to be used in the VSPackage. Icons not on the list are excluded form compilation.  
  
         The Bitmap block should look like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
7.  In the existing <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element, set the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> element to the GUIDSymbol and IDSymbol values you created earlier. Here’s an example of a Button element with those values:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
8.  Test your icon. Build the project and start debugging. In the experimental instance, find the command. It should show the icon you added.  
  
## See Also  
 [Common Menu Tasks](../vs140/extending-menus-and-commands.md)   
 [VSCT XML Schema Reference](../vs140/vsct-xml-schema-reference.md)