---
title: "IDebugArrayObject::GetDimensions"
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
  - "IDebugArrayObject::GetDimensions"
helpviewer_keywords: 
  - "IDebugArrayObject::GetDimensions method"
ms.assetid: 113e0aff-9028-49d6-b104-9fe7be4772d7
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugArrayObject::GetDimensions
Gets the dimensions of the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The number of dimensions to retrieve.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in, out] An array that is filled in with the sizes of each dimension. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> specifies the maximum size of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 A multi-dimensional array can have different sizes for each dimension. For example, given the three-dimensional array <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, this method would return 3, 2, and 6 in the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter in that order.  
  
## See Also  
 [IDebugArrayObject](../vs140/idebugarrayobject.md)