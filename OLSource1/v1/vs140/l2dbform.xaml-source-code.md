---
title: "L2DBForm.xaml Source Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 624e96d4-6d27-4195-8ac2-2f3835f6c57e
caps.latest.revision: 4
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# L2DBForm.xaml Source Code
This topic contains and describes the XAML source file for the [WPF Data Binding Using LINQ to XML Example](../vs140/wpf-data-binding-using-linq-to-xml-example.md), L2DBForm.xaml.  
  
## Overall UI Structure  
 As is typical for a WPF project, this file contains one parent element, a \<xref:System.Windows.Window*> XML element associated with the derived class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> namespace.  
  
 The client area is contained within a \<xref:System.Windows.Controls.StackPanel*> that is given a light blue background. This panel contains four \<xref:System.Windows.Controls.DockPanel*> UI sections separated by \<xref:System.Windows.Controls.Separator*> bars. The purpose of these sections is described in the **Remarks** in the [previous topic](../vs140/walkthrough--linqtoxmldatabinding-example.md).  
  
 Each section contains a label that identifies it. In the first two sections, this label is rotated 90 degrees through the use of a \<xref:System.Windows.FrameworkElement.LayoutTransform*>. The remainder of the section contains UI elements appropriate to the purpose of that section: text blocks, text boxes, buttons, and so on. Sometimes a child \<xref:System.Windows.Controls.StackPanel*> is used to align these child controls.  
  
## Window Resource Section  
 The opening <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> tag on line 9 indicates the start of the window resource section. It ends with the closing tag on line 35.  
  
 The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> tag, which spans lines 11 through 25, declares a \<xref:System.Windows.Data.ObjectDataProvider*>, named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, that uses an \<xref:System.Xml.Linq.XElement*> as the source. This \<xref:System.Xml.Linq.XElement*> is initialized by parsing an embedded XML document (a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element). Notice that white space is preserved when declaring the embedded XML document and also when it is parsed. This was done because the \<xref:System.Windows.Controls.TextBlock*> control, which is used to display the raw XML, has no special XML formatting capabilities.  
  
 Lastly, a \<xref:System.Windows.DataTemplate*> named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is defined on lines 28 through 34. This template will be used to display the entries in the **Book List** UI section. It uses data binding and LINQ to XML dynamic properties to retrieve the book ID and book name through the following assignments:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Data Binding Code  
 In addition to the \<xref:System.Windows.DataTemplate*> element, data binding is used in a number of other places in this file.  
  
 In the opening <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> tag on line 38, the \<xref:System.Windows.FrameworkElement.DataContext*> property of this panel is set to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> data provider.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This makes it possible (on line 46) for the \<xref:System.Windows.Controls.TextBlock*> named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to display the raw XML by binding to this data provider's <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> property:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The \<xref:System.Windows.Controls.ListBox*> in the **Book List** UI section, on lines 58 through 62, sets the template for its display items to the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> defined in the window resource section:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Then, on lines 59 through 62, the actual values of the books are bound to this list box:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The third UI section, **Edit Selected Book**, first binds the \<xref:System.Windows.FrameworkElement.DataContext*> of the parent \<xref:System.Windows.Controls.StackPanel*> to the currently selected item in from the **Book List** UI section (line 82):  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 It then uses two-way data binding, so that the current values of the book elements are displayed to and updated from the two text boxes in this panel. Data binding to dynamic properties is similar to that used in the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> data template:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The last UI section, **Add New Book**, does not use data binding in its XAML code; instead, such code can be found in its event handling code in the file L2DBForm.xaml.cs.  
  
## Example  
  
### Description  
  
> [!NOTE]
>  We recommend that you copy the following code below into a code editor, such as the C# source code editor in Visual Studio, so that line numbers will be easier to track.  
  
### Code  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Comments  
 For the C# source code for the event handlers associated with the WPF UI elements, see [L2DBForm.xaml.cs Source Code](../vs140/l2dbform.xaml.cs-source-code.md).  
  
## See Also  
 [Walkthrough: LinqToXmlDataBinding Example](../vs140/walkthrough--linqtoxmldatabinding-example.md)   
 [L2DBForm.xaml.cs Source Code](../vs140/l2dbform.xaml.cs-source-code.md)