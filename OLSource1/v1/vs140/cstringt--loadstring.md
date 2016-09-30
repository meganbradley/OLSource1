---
title: "CStringT::LoadString"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "CStringT.LoadString"
  - "ATL::CStringT::LoadString"
  - "ATL.CStringT.LoadString"
  - "CStringT::LoadString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadString method"
ms.assetid: 2d5053e3-3b00-48e4-8ea6-a35bfec6445e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::LoadString
Reads a Windows string resource, identified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, into an existing <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A handle to the instance of the module.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A Windows string resource ID.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The language of the string resource.  
  
## Return Value  
 Nonzero if resource load was successful; otherwise 0.  
  
## Remarks  
 Loads the string resource (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) from the specified module (<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) using the specified language (<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#124](../vs140/codesnippet/CPP/cstringt--loadstring_1.cpp)]  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)