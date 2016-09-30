---
title: "IDebugBinder3::GetAllAliases"
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
  - "IDebugBinder3::GetAllAliases"
helpviewer_keywords: 
  - "IDebugBinder3::GetAllAliases method"
ms.assetid: 1f9ab2ee-2ab3-4a61-8b99-95dd7fdf3511
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBinder3::GetAllAliases
This method retrieves a list of aliases from the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The maximum number of aliases to return (specifies the length of the array passed into <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in, out] Array to fill in with aliases (if this is a null value and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is 0, the count of aliases that can be returned will be returned by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Returns the number of aliases obtained.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugBinder3](../vs140/idebugbinder3.md)