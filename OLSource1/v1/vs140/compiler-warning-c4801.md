---
title: "Compiler Warning C4801"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4801"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4801"
ms.assetid: 05b29dff-15ef-42ca-9712-dc993afc4fd6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4801
Return by reference is not verifiable: reason  
  
 You cannot store a tracking reference into a local variable and then return it verifiably.  
  
 A reference can only be verifiably returned when it can be tracked by the verifier from creation to return point and when it is a reference to an element of an array, or a member of a class.  
  
 For more information, see [PEVerify Tool (Peverify.exe)](assetId:///f4f46f9e-8d08-4e66-a94b-0c69c9b0bbfa).  
  
 A reference must remain on the stack from creation to return in order to be verifiable.  
  
 C4801 is always issued as an error.  You can turn off this warning with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or **/wd**; see [warning](../vs140/warning.md) or [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) for more information.  
  
## Example  
 C4801 will be generated if the verifier cannot see the address taken, so it must assume that it might be an unverifiable reference. The following sample generates C4801.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C4801.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 C4801 can also occur if you attempt to dereference and return a reference value in a try block. This will result in code that cannot be verified because the stack is cleared at the end of a try block, destroying any return value on the stack. Instead, dereference the reference type and assign it to a variable, to ensure that no exception is thrown. Then, at the end of the function, dereference the reference type again and return it.  
  
 The following sample generates C4801.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>