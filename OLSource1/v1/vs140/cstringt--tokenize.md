---
title: "CStringT::Tokenize"
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
  - "ATL.CStringT.Tokenize"
  - "ATL::CStringT::Tokenize"
  - "CStringT.Tokenize"
  - "CStringT::Tokenize"
  - "Tokenize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Tokenize method"
ms.assetid: 1be32c0f-b75d-4cad-9482-4eac0901fea3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStringT::Tokenize
Finds the next token in a target string  
  
## Syntax  
  
```  
CStringT Tokenize(  
   PCXSTR pszTokens,  
   int& iStart  
) const;  
```  
  
#### Parameters  
 `pszTokens`  
 A string containing token delimiters. The order of these delimiters is not important.  
  
 `iStart`  
 The zero-based index to begin the search.  
  
## Return Value  
 A `CStringT` object containing the current token value.  
  
## Remarks  
 The `Tokenize` function finds the next token in the target string. The set of characters in `pszTokens` specifies possible delimiters of the token to be found. On each call to `Tokenize` the function starts at `iStart`, skips leading delimiters, and returns a `CStringT` object containing the current token, which is the string of characters up to the next delimiter character. The value of `iStart` is updated to be the position following the ending delimiter character, or -1 if the end of the string was reached. More tokens can be broken out of the remainder of the target string by a series of calls to `Tokenize`, using `iStart` to keep track of where in the string the next token is to be read. When there are no more tokens the function will return an empty string and `iStart` will be set to -1.  
  
 Unlike the CRT tokenize functions like [strtok_s](../vs140/strtok_s--_strtok_s_l--wcstok_s--_wcstok_s_l--_mbstok_s--_mbstok_s_l.md), `Tokenize` does not modify the target string.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#135](../vs140/codesnippet/CPP/cstringt--tokenize_1.cpp)]  
  
## Remarks  
 The output from this example is as follows:  
  
 `Resulting Token: First`  
  
 `Resulting Token: Second`  
  
 `Resulting Token: Third`  
  
## Requirements  
 **Header:** cstringt.h  
  
## See Also  
 [CStringT Class](../vs140/cstringt-class.md)