---
title: "Start Page Architecture"
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
  - "start page architecture"
  - "start page xaml"
ms.assetid: f94afe27-0be3-47d9-8e17-b0fd429017bd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Start Page Architecture
This document describes the architecture of the Start Page tool window that is included in Visual Studio. You can use this information to add or change items on the Start Page without changing its underlying structure.  
  
 The Visual Studio Start Page is written in Windows Presentation Foundation (WPF) Extensible Application Markup Language (XAML). For more information about XAML markup, see [XAML Overview (WPF)](assetId:///a80db4cd-dd0f-479f-a45f-3740017c22e4).  
  
## Page Structure  
 The Start Page consists of an \<xref:System.Windows.Controls.Image*> element and two \<xref:System.Windows.Controls.Grid*> elements in a top level <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element spans the top of the tool window and contains the Visual Studio logo. Below the logo, the left <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element contains the command buttons for new projects, the **Recent Projects** list, and an area for Start Page options. The right <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element contains a \<xref:System.Windows.Controls.TabControl*> element that has a **Get Started** tab, a **Guidance and Resources** tab, and a **Latest News** tab. A central column is defined between the left and right <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> elements, but it has no content and is used only as a spacer.  
  
### Window Body  
 The background of the tool window is represented by the top-level <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. The widths of the main columns are defined here, in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element. The height of the logo image is set in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element.  
  
 Row definitions and column definitions are stored in zero-based arrays. To position an element in a grid, set the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attributes to match the indexes of the corresponding \<xref:System.Windows.Controls.ColumnDefinition*> and \<xref:System.Windows.Controls.RowDefinition*> elements.  
  
### Logo Image  
 The Visual Studio logo occupies the top row of the top-level grid (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) as an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element. To display a different image, point the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element to a different image file. To remove the image, delete the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element and set the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attribute of the corresponding top-level <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element to <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> (zero) to hide the top row of the grid.  
  
### Left Column  
 The left column of the Start Page is represented by a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> element at <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. This element contains definitions for three rows, which host the Command Buttons grid, the Recent Projects grid, and a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element to display Visual Studio options.  
  
 You can add an element to this grid by adding it to one of the existing rows or by adding a new row definition. When you define a new row, remember to increment the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> values of any elements that appear under the new row.  
  
### Middle Column  
 The middle column is a spacer and contains no elements. To add an element to the middle column, position it at <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. Make sure to adjust the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute of the column definition to accommodate the change.  
  
### Right Column  
 The right column contains a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> element at <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The grid contains a <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> element that has three tabs.  
  
 You can add a tab by adding a \<xref:System.Windows.Controls.TabItem*> element to the tab control, as shown in [Walkthrough: Adding Custom XAML to the Start Page](../vs140/walkthrough--adding-custom-xaml-to-the-start-page.md), or you can edit or remove existing tabs. Tabs appear left to right in the user interface (UI) in the same order as they appear top to bottom in the markup.  
  
 If you add an element to the right column grid outside of the tab control, we recommend that you define a new row or column in the grid to ensure that it appears as expected.  
  
## See Also  
 [Customizing the Start Page](../vs140/customizing-the-start-page-for-visual-studio.md)   
 [Start Page Best Practices](../vs140/start-page-best-practices.md)   
 [How to: Deploy a Custom Start Page](../vs140/deploying-custom-start-pages.md)