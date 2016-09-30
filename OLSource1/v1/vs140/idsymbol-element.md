---
title: "IDSymbol Element"
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
  - "IDSymbol element (VSCT XML schema)"
  - "VSCT XML schema elements, IDSymbol"
ms.assetid: 760cfd20-3c06-422c-9103-98bfa1f387f8
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDSymbol Element
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> element contains the ID of the GUID:ID pair that represents a menu, group, or command. The GUID comes from the parent <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element has a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> attribute that provides a friendly name for the ID, which is contained in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|name|Required. Name of the ID symbol.|  
|value|Required. Numeric ID value of the ID symbol.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[GuidSymbol Element](../vs140/guidsymbol-element.md)|Contains the GUID of the GUID:ID pair that represents a menu, group, or command. Groups <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements.|  
  
## Remarks  
 Every <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element in a given <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element must have a unique <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. However, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> elements that have identical values can exist in a package as long as they have different parents.  
  
## See Also  
 [XML-Based Command Table Configuration (.vsct) Files](../vs140/visual-studio-command-table--.vsct--files.md)