---
title: "IDebugProperty3::GetStringChars"
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
  - "IDebugProperty3::GetStringChars"
helpviewer_keywords: 
  - "IDebugProperty3::GetStringChars"
ms.assetid: 832c37f3-85cb-4227-8ab2-f27a80eafe90
caps.latest.revision: 11
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProperty3::GetStringChars
Retrieves the string associated with this property and stores it in a user-supplied buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Maximum number of characters the user-supplied buffer can hold.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] Returns the string.  
  
 [C++ only], <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a pointer to a buffer that receives the Unicode characters of the string. This buffer must be at least <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> characters (not bytes) in size.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [out] Where the number of characters actually stored in the buffer is returned. (Can be <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in C++.)  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise returns an error code.  
  
## Remarks  
 In C++, care must be taken to insure that the buffer is at least <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Unicode characters long. Note that a Unicode character is 2 bytes long.  
  
> [!NOTE]
>  In C++, the returned string does not include a terminating null character. If given, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> will specify the number of characters in the string.  
  
## Example  
 [!CODE [[cpp]]([cpp])]  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [!CODE [}](})]  
  
## See Also  
 [IDebugProperty3::GetStringCharLength](../vs140/idebugproperty3--getstringcharlength.md)   
 [IDebugProperty3](../vs140/idebugproperty3.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)