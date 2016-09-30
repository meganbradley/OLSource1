---
title: "L2DBForm.xaml.cs Source Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5a40dad3-6763-4576-b3ad-874df3f2c8d9
caps.latest.revision: 6
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# L2DBForm.xaml.cs Source Code
This topic contains the contents and description of the C# source code in the file L2DBForm.xaml.cs. The L2XDBForm partial class contained in this file can be divided into three logical sections: data members and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> button click event handlers.  
  
## Data Members  
 Two private data members are used to associate this class to the window resources used in L2DBForm.xaml.  
  
-   The namespace variable <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is initialized to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
-   The member <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is initialized in the constructor to the CDATA string in L2DBForm.xaml with the following line:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## OnAddBook Event Handler  
 This method contains the following three statements:  
  
-   The first conditional statement is used for input validation.  
  
-   The second statement creates a new \<xref:System.Xml.Linq.XElement*> from the string values the user entered in the **Add New Book** user interface (UI) section.  
  
-   The last statement adds this new book element to the data provider in L2DBForm.xaml. Consequently, dynamic data binding will automatically update the UI with this new item; no extra user-supplied code is required.  
  
## OnRemove Event Handler  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> handler is more complicated than the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> handler for two reasons. First, because the raw XML contains preserved white space, matching newlines must also be removed with the book entry. Second, as a convenience, the selection, which was on the deleted item, is reset to the previous one in the list.  
  
 However the core work of removing the selected book item is accomplished by only two statements:  
  
-   First, the book element associated with the currently selected item in the list box is retrieved:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Then, this element is deleted from the data provider:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Again, dynamic data binding assures that the program's UI is automatically updated.  
  
## Example  
  
### Description  
  
### Code  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Comments  
 For the associated XAML source for these handlers, see [L2DBForm.xaml Source Code](../vs140/l2dbform.xaml-source-code.md).  
  
## See Also  
 [Walkthrough: LinqToXmlDataBinding Example](../vs140/walkthrough--linqtoxmldatabinding-example.md)   
 [L2DBForm.xaml Source Code](../vs140/l2dbform.xaml-source-code.md)