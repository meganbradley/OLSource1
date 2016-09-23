---
title: "DDX_IPAddress"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - DDX_IPAddress
dev_langs: 
  - C++
helpviewer_keywords: 
  - DDX_IPAddress function
  - IP address control, DDX
ms.assetid: 54ec9bed-b3b4-4008-837c-5c46994f7109
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# DDX_IPAddress
The `DDX_IPAddress` function manages the transfer of data between an IP Address control and a data member of the control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_IPAddress(  
   CDataExchange* pDX,  
   int nIDC,  
   DWORD& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a `CDataExchange` object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 `nIDC`  
 The resource ID of the IP Address control associated with the control property.  
  
 *value*  
 A reference to the `DWORD` containing the four-field value of the IP Address control. The fields are filled or read as follows.  
  
|Field|Bits containing the field value|  
|-----------|-------------------------------------|  
|3|0 through 7|  
|2|8 through 15|  
|1|16 through 23|  
|0|24 through 31|  
  
 Use the Win32 [IPM_GETADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761378) to read the value, or use [IPM_SETADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761380) to fill the value. These messages are described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 When `DDX_IPAddress` is called, *value* is either read from the IP Address control, or *value* is written to the control, depending on the direction of the exchange.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CIPAddressCtrl Class](../vs140/cipaddressctrl-class.md)