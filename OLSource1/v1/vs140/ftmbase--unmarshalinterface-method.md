---
title: "FtmBase::UnmarshalInterface Method"
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
  - "ftm/Microsoft::WRL::FtmBase::UnmarshalInterface"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnmarshalInterface method"
ms.assetid: 6850a621-e9a6-4001-bc1e-bd5d1b121adc
caps.latest.revision: 7
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# FtmBase::UnmarshalInterface Method
Initializes a newly created proxy and returns an interface pointer to that proxy.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the stream from which the interface pointer is to be unmarshaled.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Reference to the identifier of the interface to be unmarshaled.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 When this operation completes, the address of a pointer variable that receives the interface pointer requested in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If this operation is successful, *<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> contains the requested interface pointer of the interface to be unmarshaled.  
  
## Return Value  
 S_OK if successful; otherwise, E_NOINTERFACE or E_FAIL.  
  
## Requirements  
 **Header:** ftm.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [FtmBase Class](../vs140/ftmbase-class.md)