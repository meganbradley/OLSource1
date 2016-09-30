---
title: "lcid"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "vc-attr.lcid"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LCID attribute"
ms.assetid: 7f248c69-ee1c-42c3-9411-39cf27c9f43d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# lcid
Lets you pass a locale identifier to a function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The **lcid** C++ attribute implements the functionality of the [lcid](http://msdn.microsoft.com/library/windows/desktop/aa367067) MIDL attribute. If you want to implement locale for a library block, use the **lcid=**<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter to the [module](../vs140/module--c---.md) attribute.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|Interface parameter|  
|**Repeatable**|No|  
|**Required attributes**|None|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../vs140/attribute-contexts.md).  
  
## See Also  
 [IDL Attributes](../vs140/idl-attributes.md)   
 [Parameter Attributes](../vs140/parameter-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)