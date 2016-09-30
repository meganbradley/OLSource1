---
title: "IDebugField::GetContainer"
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
  - "IDebugField::GetContainer"
helpviewer_keywords: 
  - "IDebugField::GetContainer method"
ms.assetid: 6d6c8213-6181-4adf-9584-3e4cac163dd8
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugField::GetContainer
This method gets the container of a field.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns the container as represented by the [IDebugContainerField](../vs140/idebugcontainerfield.md) interface.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 If this field does not have a container, the returned <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will be a null value.  
  
## See Also  
 [IDebugField](../vs140/idebugfield.md)   
 [IDebugContainerField](../vs140/idebugcontainerfield.md)