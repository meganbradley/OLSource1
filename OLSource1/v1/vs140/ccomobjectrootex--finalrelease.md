---
title: "CComObjectRootEx::FinalRelease"
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
  - "CComObjectRootEx.FinalRelease"
  - "CComObjectRootEx::FinalRelease"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "aggregation [C++], CComObjectRootEx"
  - "FinalRelease method"
ms.assetid: 52481a2e-e5f8-4fad-9814-362e62f4eed9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::FinalRelease
You can override this method in your derived class to perform any cleanup required for your object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 By default, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> does nothing.  
  
 Performing cleanup in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is preferable to adding code to the destructor of your class since the object is still fully constructed at the point at which <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called. This enables you to safely access the methods provided by the most derived class. This is particularly important for freeing any aggregated objects before deletion.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)   
 [CComObjectRootEx::FinalConstruct](../vs140/ccomobjectrootex--finalconstruct.md)