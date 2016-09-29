---
title: "CIPAddressCtrl::GetAddress"
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
  - "CIPAddressCtrl.GetAddress"
  - "CIPAddressCtrl::GetAddress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAddress method"
ms.assetid: 9faa340e-917a-4745-99c0-de85ad0d96a2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CIPAddressCtrl::GetAddress
Retrieves the address values for all four fields in the IP Address Control.  
  
## Syntax  
  
```  
  
      int GetAddress(  
   BYTE& nField0,  
   BYTE& nField1,  
   BYTE& nField2,  
   BYTE& nField3   
);  
int GetAddress(  
   DWORD& dwAddress   
);  
```  
  
#### Parameters  
 `nField0`  
 A reference to the field 0 value from a packed IP address.  
  
 `nField1`  
 A reference to the field 1 value from a packed IP address.  
  
 `nField2`  
 A reference to the field 2 value from a packed IP address.  
  
 `nField3`  
 A reference to the field 3 value from a packed IP address.  
  
 `dwAddress`  
 A reference to the address of a `DWORD` value that receives the IP address. See **Remarks** for a table that shows how `dwAddress` is filled.  
  
## Return Value  
 The number of non-blank fields in the IP Address Control.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [IPM_GETADDRESS](http://msdn.microsoft.com/library/windows/desktop/bb761378), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In the first prototype above, the numbers in fields 0 through 3 of the control, read left to right respectively, populate the four parameters. In the second prototype above, `dwAddress` is populated as follows.  
  
|Field|Bits containing the field value|  
|-----------|-------------------------------------|  
|0|24 through 31|  
|1|16 through 23|  
|2|8 through 15|  
|3|0 through 7|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CIPAddressCtrl Class](../vs140/cipaddressctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CIPAddressCtrl::SetAddress](../vs140/cipaddressctrl--setaddress.md)