---
title: "IDiaAddressMap::set_imageHeaders"
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
  - "IDiaAddressMap::set_imageHeaders method"
ms.assetid: a46b9d0e-43e6-433f-b2c7-aa203981e4e4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaAddressMap::set_imageHeaders
Sets image headers to enable relative virtual address translation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 cbData  
 [in] Number of bytes of header data. Must be <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> where <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is the number of section headers in the executable.  
  
 data[]  
 [in] An array of  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> structures to be used as the image headers.  
  
 originalHeaders  
 [in] Set to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the image headers are from the new image, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if they reflect the original image prior to an upgrade. Typically, this would be set to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> only in combination with calls to the [IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md) method.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> structure is declared in Winnt.h and represents the image section header format of the executable.  
  
 Relative virtual address calculations depend upon the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> values. Usually, the DIA retrieves these from the program database (.pdb) file. If these values are missing, the DIA is unable to calculate relative virtual addresses and the [IDiaAddressMap::get_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--get_relativevirtualaddressenabled.md) method returns <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The client must then call the [IDiaAddressMap::put_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--put_relativevirtualaddressenabled.md) method to enable the relative virtual address calculations after providing the missing image headers from the image itself.  
  
## See Also  
 [IDiaAddressMap](../vs140/idiaaddressmap.md)   
 [IDiaAddressMap::set_addressMap](../vs140/idiaaddressmap--set_addressmap.md)   
 [IDiaAddressMap::get_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--get_relativevirtualaddressenabled.md)   
 [IDiaAddressMap::put_relativeVirtualAddressEnabled](../vs140/idiaaddressmap--put_relativevirtualaddressenabled.md)