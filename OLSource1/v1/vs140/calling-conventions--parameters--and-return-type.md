---
title: "Calling Conventions, Parameters, and Return Type"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "calling conventions, helper functions"
  - "helper functions, calling conventions"
  - "helper functions, return types"
ms.assetid: 0ffa4558-6005-4803-be95-7a8ec8837660
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Calling Conventions, Parameters, and Return Type
The helper routine's prototype is:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 where:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (see delayimp.h) that contains the offsets of various import-related data, a timestamp for binding information, and a set of attributes that provide further information about the descriptor content. Currently there is only one attribute, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which indicates that the addresses in the descriptor are relative virtual addresses (as opposed to virtual addresses).  
  
 For the definition of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure, see [Structure and Constant Definitions](../vs140/structure-and-constant-definitions.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to the slot in the delay load import address table (IAT) to be updated with the address of the imported function. The helper routine needs to store the same value that it will be returning into this location.  
  
## Expected Return Values  
 If the function is successful, it returns the address of the imported function.  
  
 If the function fails, it raises an exception and returns 0. Three types of exceptions can be raised:  
  
-   Invalid parameter, which happens if the attributes in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> aren't specified correctly.  
  
-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> failed on the specified DLL.  
  
-   Failure of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 It is your responsibility to handle these exceptions.  
  
## Remarks  
 The calling convention for the helper function is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. The type of the return value is not relevant, so FARPROC is used. This function has C linkage.  
  
 The return value of the delay load helper needs to be stored in the passed-in function pointer location, unless you want your helper routine to be used as a notification hook. In that case, your code is responsible for finding the appropriate function pointer to return. The thunk code the linker generates then takes that return value as the real target of the import and jumps directly to it.  
  
## Sample  
 The following code shows how to implement a simple hook function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Understanding the Helper Function](../vs140/understanding-the-helper-function.md)