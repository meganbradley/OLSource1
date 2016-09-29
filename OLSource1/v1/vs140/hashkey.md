---
title: "HashKey"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXTEMPL/HashKey"
  - "HashKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HashKey function"
ms.assetid: cc696952-7443-4314-99b1-b9cbb06517c6
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# HashKey
Calculates a hash value for the given key.  
  
## Syntax  
  
```  
  
      template<class ARG_KEY>  
AFX_INLINE UINT AFXAPI HashKey(  
   ARG_KEY key   
);  
```  
  
#### Parameters  
 `ARG_KEY`  
 Template parameter specifying the data type used to access map keys.  
  
 `key`  
 The key whose hash value is to be calculated.  
  
## Return Value  
 The key's hash value.  
  
## Remarks  
 This function is called directly by [CMap::RemoveKey](../vs140/cmap--removekey.md) and indirectly by [CMap::Lookup](../vs140/cmap--lookup.md) and [CMap::Operator &#91;&#93;](../vs140/cmap--operator.md).  
  
 The default implementation creates a hash value by shifting `key` right by four positions. Override this function so that it returns hash values appropriate for your application.  
  
## Example  
 [!code[NVC_MFC_Utilities#34](../vs140/codesnippet/CPP/hashkey_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CMap Class](../vs140/cmap-class.md)