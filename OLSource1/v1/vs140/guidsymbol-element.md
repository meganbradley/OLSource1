---
title: "GuidSymbol Element"
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
  - "VSCT XML schema elements, GuidSymbol"
  - "GuidSymbol element (VSCT XML schema)"
ms.assetid: 11fb3545-8974-4776-9a54-6b6e7739ae31
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# GuidSymbol Element
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element contains the GUID of the GUID:ID pair that represents a menu, group, or command. The ID comes from an <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element has a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute that provides a friendly name for the GUID, which is contained in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|name|Required. Name of the GUID symbol.|  
|value|Required. GUID of the GUID symbol.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[IDSymbol Element](../vs140/idsymbol-element.md)|Contains the ID of the GUID:ID pair that represents a menu, group, or command.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Symbols Element](../vs140/symbols-element.md)|Groups <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements in a .vsct file.|  
  
## Remarks  
 Typically, a .vsct file contains three <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements in its <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> section, one for the package itself, one for the command set (the collection of menus, groups, and commands that the package makes available), and one for the bitmaps that provide icons for buttons and other visual components. Every <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element in a given <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element must have a unique <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.However, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements that have identical values can exist in a package as long as they have different parents.  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)