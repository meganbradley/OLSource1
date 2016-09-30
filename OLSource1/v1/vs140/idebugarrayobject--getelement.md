---
title: "IDebugArrayObject::GetElement"
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
  - "IDebugArrayObject::GetElement"
helpviewer_keywords: 
  - "IDebugArrayObject::GetElement method"
ms.assetid: 08b44341-7bf1-4a8c-8b79-98ae5785b195
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayObject::GetElement
Gets an element of the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The element index.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns an [IDebugObject](../vs140/idebugobject.md) interface that represents the element.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method sees all of the elements of an array object as a one-dimensional array, even if the array object is multi-dimensional. For example, given the array <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of 20, this method would return the element from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter of 21 would return the element from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Use the [IDebugArrayObject::GetCount](../vs140/idebugarrayobject--getcount.md) method to determine the total number of elements in the array.  
  
## See Also  
 [IDebugArrayObject](../vs140/idebugarrayobject.md)