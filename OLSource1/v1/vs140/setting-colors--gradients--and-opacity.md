---
title: "Setting Colors, Gradients, and Opacity"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "UI element design [Visual Studio SDK]"
ms.assetid: 1734bdc7-5e16-46c7-8507-eef5cea75cb9
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Setting Colors, Gradients, and Opacity
All of the user interface (UI) elements in Visual Studio are created in Windows Presentation Foundation (WPF). Therefore, when you create tool windows or other UI elements, you can apply colors, gradients, and opacity by setting the appropriate attributes on those elements. You can set these to specific values by using the **Properties** window, or you can query the integrated development environment (IDE) for system values. We recommend that you use system values when you want your extensions to resemble the rest of the IDE.  
  
 Windows Forms UI and native-code UI are still supported for backward compatibility. For information about how to set colors and gradients in non-WPF extensions, see the [!INCLUDE[vs_orcas_long](../vs140/includes/vs_orcas_long_md.md)] documentation.  
  
## Setting Colors, Gradients, and Opacity  
 You can set change the appearance of most XAML elements by setting their <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or other visual attributes. These attributes correspond to properties that take a \<xref:System.Windows.Media.Brush*?displayProperty=fullName> as a value.  
  
#### To set background colors, gradients, and opacity in a tool window  
  
1.  Open MyControl.xaml.  
  
2.  In the **XAML** pane, in the top level \<xref:System.Windows.Controls.UserControl*> element, type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
     IntelliSense displays a list of colors for the BackGround attribute.  
  
     Select a color from the list.  
  
3.  In the **Properties** window, expand the **Brushes** node, and then click **Background**.  
  
     The **Properties** window displays a color picker. Above the color picker is a row of icons that represent brushes.  
  
4.  Use the sliders to pick a color.  
  
     The XAML immediately updates to show the new background color.  
  
5.  Click the Gradient Brush icon.  
  
     The color picker changes to a gradient picker.  
  
6.  Use the sliders to pick a gradient.  
  
     The XAML immediately updates to show the new background gradient.  
  
7.  Click the Image Brush icon.  
  
     The gradient picker changes to an image selection tool.  
  
8.  Select an image and set its stretch and tile parameters.  
  
     The XAML immediately updates to show the new background image.  
  
9. Click the Null Brush icon.  
  
     The background in the designer returns to neutral, and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute is set to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Querying System Values  
 You can query system values by using the \<xref:Microsoft.VisualStudio.Shell.VsBrushes*?displayProperty=fullName> class properties, which refer to brushes that are set in other parts of Visual Studio.  
  
#### To set colors, gradients, and opacity by querying system values  
  
1.  Select a XAML element.  
  
2.  In the element definition, set one of the visual attributes of the element to a property of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class, as shown in the following example.  
  
     [!code[TWShortcutMenu#32](../vs140/codesnippet/Xaml/setting-colors--gradients--and-opacity_1.xaml)]  
  
     Using the [DynamicResource](assetId:///7324f243-03af-4c2b-b0db-26ac6cdfcbe4) extension enables the value to change as required, for example, when a user changes the settings. You must use the [x:Static](assetId:///056aee79-7cdd-434f-8174-dfc856cad343) extension because the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class is not part of the default WPF namespace.  
  
## See Also  
 [Tool Windows](../vs140/extending-tool-windows.md)