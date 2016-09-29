---
title: "PX_Blob"
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
  - "AFXCTL/PX_Blob"
  - "PX_Blob"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_Blob function"
ms.assetid: 83a1293f-d3a3-42b2-b737-2d17c729c176
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_Blob
Call this function within your control's `DoPropExchange` member function to serialize or initialize a property that stores binary large object (BLOB) data.  
  
## Syntax  
  
```  
  
      BOOL PX_Blob(  
   CPropExchange* pPX,  
   LPCTSTR pszPropName,  
   HGLOBAL& hBlob,  
   HGLOBAL hBlobDefault = NULL   
);  
```  
  
#### Parameters  
 `pPX`  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to `DoPropExchange`).  
  
 `pszPropName`  
 The name of the property being exchanged.  
  
 `hBlob`  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 `hBlobDefault`  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value will be read from or written to the variable referenced by `hBlob`, as appropriate. This variable should be initialized to **NULL** before initially calling `PX_Blob` for the first time (typically, this can be done in the control's constructor). If `hBlobDefault` is specified, it will be used as the property's default value. This value is used if, for any reason, the control's initialization or serialization process fails.  
  
 The handles `hBlob` and `hBlobDefault` refer to a block of memory which contains the following:  
  
-   A `DWORD` which contains the length, in bytes, of the binary data that follows, followed immediately by  
  
-   A block of memory containing the actual binary data.  
  
 Note that `PX_Blob` will allocate memory, using the Windows [GlobalAlloc](http://msdn.microsoft.com/library/windows/desktop/aa366574) API, when loading BLOB-type properties. You are responsible for freeing this memory. Therefore, the destructor of your control should call [GlobalFree](http://msdn.microsoft.com/library/windows/desktop/aa366579) on any BLOB-type property handles to free up any memory allocated to your control.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)