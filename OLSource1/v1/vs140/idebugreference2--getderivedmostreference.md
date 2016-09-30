---
title: "IDebugReference2::GetDerivedMostReference"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugReference2::GetDerivedMostReference"
helpviewer_keywords: 
  - "IDebugReference2::GetDerivedMostReference"
ms.assetid: 07253b74-7d39-48e0-8e85-ac8dfd919f6e
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugReference2::GetDerivedMostReference
Gets the derived-most reference of a reference. Reserved for future use.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugReference2](../vs140/idebugreference2.md) object that represents the derived-most property.  
  
## Return Value  
 Always returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 For example, if this property describes an object that implements <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> but which is actually an instantiation of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that is derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then this method returns an [IDebugReference2](../vs140/idebugreference2.md) object representing a reference to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## See Also  
 [IDebugReference2](../vs140/idebugreference2.md)