---
title: "FtmBase::GetUnmarshalClass Method"
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
  - "ftm/Microsoft::WRL::FtmBase::GetUnmarshalClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUnmarshalClass method"
ms.assetid: 535fc539-5b97-4967-b158-f7568f13d341
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FtmBase::GetUnmarshalClass Method
Gets the CLSID that COM uses to locate the DLL containing the code for the corresponding proxy. COM loads this DLL to create an uninitialized instance of the proxy.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Reference to the identifier of the interface to be marshaled.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the interface to be marshaled; can be NULL if the caller does not have a pointer to the desired interface.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Destination context where the specified interface is to be unmarshaled.  
  
 Specify one or more MSHCTX enumeration values.  
  
 Unmarshaling can occur either in another apartment of the current process (MSHCTX_INPROC) or in another process on the same computer as the current process (MSHCTX_LOCAL).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Reserved for future use; must be NULL.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 When this operation completes, pointer to the CLSID to be used to create a proxy in the client process.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
## Return Value  
 S_OK if successful; otherwise, S_FALSE.  
  
## Requirements  
 **Header:** ftm.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [FtmBase Class](../vs140/ftmbase-class.md)