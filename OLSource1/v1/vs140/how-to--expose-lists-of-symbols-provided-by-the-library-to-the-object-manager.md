---
title: "How to: Expose Lists of Symbols Provided by the Library to the Object Manager"
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
  - "IVsSimpleLibrary2 interface, lists of symbols"
  - "IVsLibrary2 interface, lists of symbols"
  - "symbols, call browser"
  - "lists, symbols for the object manager"
  - "symbols, exposing lists to the object manager"
ms.assetid: 19757068-bdaa-4e7e-85d6-f8ce5026a859
caps.latest.revision: 29
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Expose Lists of Symbols Provided by the Library to the Object Manager
The symbol-browsing tools, **Class View**, **Object Browser**, **Call Browser** and **Find Symbol Results**, pass requests for new data to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] object manager. The object manager finds the appropriate libraries and requests new lists of symbols. The libraries respond by providing requested data to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] object manager through the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2*> interface. The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] object manager calls the methods in \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2*> interface to obtain the data and uses it to populate or update the views of the symbol-browsing tools.  
  
 A library may get requests for data when the tool is invoked, the node is expanded, or the view is refreshed. When a symbol-browsing tool is invoked for the first time, the object manager requests the library to provide the top-level list. When the user expands a list node, the library provides a list of children under that node. Every object manager inquiry contains an index of the item of interest. To display a new list, the object manager must determine how many items are in the list, the type of the items, their names, accessibility, and other properties.  
  
> [!NOTE]
>  The following managed code examples demonstrate how to provide lists of symbols through implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2*> interface. The object manager calls the methods in this interface and uses the obtained data to populate or update the symbol-browsing tools.  
>   
>  For native code symbol provider implementation, use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectList2*> interface.  
  
## Providing Lists of Symbols to the Object Manager  
  
#### To provide lists of symbols to the object manager  
  
1.  Get the number of items in the list of symbols by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetItemCount*> method. The following example demonstrates how the object manager obtains the information on the number of items in the list.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Get information about the categories and the attributes of a given list item by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetCategoryField2*> method. The item categories are specified in the \<xref:Microsoft.VisualStudio.Shell.Interop.LIB_CATEGORY*> enumeration. The following example demonstrates how the object manager obtains attributes of items for a given category.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
3.  Get the text representation of a given list item by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetTextWithOwnership*> method. The following example demonstrates how to obtain a full name of a given item.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  Get the icon information for a given list item by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetDisplayData*> method. The icon represents the type (class, method, and so on), and accessibility (private, public, and so on) of a list item. The following example demonstrates how to obtain the icon information based on a given item attributes.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
5.  Get the information on whether a given list item is expandable by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetExpandable3*> method. The following example demonstrates how to obtain the information on whether a given item can be expanded.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
6.  Get a child list of symbols of a given list item by implementing the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSimpleObjectList2.GetList2*> method. The following example demonstrates how to obtain a child list of symbols of a given item for **Call** or **Callers** graphs.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [Supporting Symbol-Browsing Tools](../vs140/supporting-symbol-browsing-tools.md)   
 [How to: Register a Library with the Object Manager](../vs140/how-to--register-a-library-with-the-object-manager.md)   
 [How to: Identify the Symbols in the Library](../vs140/how-to--identify-symbols-in-a-library.md)   
 [Language Services](../vs140/legacy-language-service-extensibility.md)