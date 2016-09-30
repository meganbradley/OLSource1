---
title: "feupdateenv"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "cpp"
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "feupdateenv"
apitype: "HeaderDef"
f1_keywords: 
  - "feupdateenv"
  - "fenv/feupdateenv"
dev_langs: 
  - "C"
  - "C++"
helpviewer_keywords: 
  - "feupdateenv function"
ms.assetid: 3d170042-dfd5-4e4f-a55f-038cf2296cc9
caps.latest.revision: 7
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# feupdateenv
Saves the currently raised floating-point exceptions, restores the specified floating-point environment state, and then raises the saved floating-point exceptions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that contains a floating-point environment as set by a call to [fegetenv](assetId:///61df848d-6ba8-4c6e-be35-216436fe7736) or [feholdexcept](assetId:///c286ace3-ec39-482a-be8b-f998d31003d9). You can also specify the default startup floating-point environment by using the FE_DFL_ENV macro.  
  
## Return Value  
 Returns 0 if all actions completed successfully.        Otherwise, returns a nonzero value.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function performs multiple actions. First, it stores the current raised floating-point exception status flags in automatic storage. Then, it sets the current floating-point environment from the value stored in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not FE_DFL_ENV or does not point to a valid <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object, subsequent behavior is undefined. Finally, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> raises the locally stored floating-point exceptions.  
  
 To use this function, you must turn off floating-point optimizations that could prevent access by using the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> directive prior to the call. For more information, see [fenv_access](../vs140/fenv_access.md).  
  
## Requirements  
  
|Function|C header|C++ header|  
|--------------|--------------|------------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|\<fenv.h>|\<cfenv>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## See Also  
 [fegetenv](../vs140/fegetenv.md)   
 [feclearexcept](../vs140/feclearexcept.md)   
 [feholdexcept](../vs140/feholdexcept.md)   
 [fesetexceptflag](../vs140/fesetexceptflag.md)