---
title: "IDiaAddressMap::put_addressMapEnabled"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaAddressMap::put_addressMapEnabled method"
ms.assetid: 0f205337-4e59-4383-8059-7b1d207d6dcd
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaAddressMap::put_addressMapEnabled
Specifies whether the address map should be used to translate symbol addresses.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 NewVal  
 [in] Set to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to enable the translation of symbols, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to disable.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 Executable post-processors sometimes update the executable. DIA contains a mechanism to support the translation of symbols to the new layout.  
  
 When a PDB file is loaded, the address map stored in the file is enabled. There are times, however, when a client application may need to supply its own address map by calling the [IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md) method. If the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method is successful, the client application must call the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method with a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to enable the use of that address map.  
  
 The current state of the address map being enabled can be retrieved with a call to the [IDiaAddressMap::get_addressMapEnabled](../vs140/idiaaddressmap--get_addressmapenabled.md) method.  
  
## See Also  
 [IDiaAddressMap](../vs140/idiaaddressmap.md)   
 [IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md)   
 [IDiaAddressMap::get_addressMapEnabled](../vs140/idiaaddressmap--get_addressmapenabled.md)