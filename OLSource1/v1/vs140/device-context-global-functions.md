---
title: "Device Context Global Functions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: 08ec28f6-daff-4882-9544-e8a4639d05c4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Device Context Global Functions
This function creates a device context for a given device.  
  
|||  
|-|-|  
|[AtlCreateTargetDC](../vs140/atlcreatetargetdc.md)|Creates a device context.|  
  
##  <a name="atlcreatetargetdc"></a>  AtlCreateTargetDC  
 Creates a device context for the device specified in the                 [DVTARGETDEVICE](http://msdn.microsoft.com/library/windows/desktop/ms686613) structure.  
  
```  
  
HDC  
AtlCreateTargetDC(  
   HDC  
hdc  
,  
   DVTARGETDEVICE*  
ptd   
);  
  
```  
  
### Parameters  
 *hdc*  
 [in] The existing handle of a device context, or                                 **NULL**.  
  
 `ptd`  
 [in] A pointer to the                                 **DVTARGETDEVICE** structure that contains information about the target device.  
  
### Return Value  
 Returns the handle to a device context for the device specified in the                         **DVTARGETDEVICE**. If no device is specified, returns the handle to the default display device.  
  
### Remarks  
 If the structure is                         **NULL** and                         *hdc* is                         **NULL**, creates a device context for the default display device.  
  
 If                         *hdc* is not                         **NULL** and                         `ptd` is                         **NULL**, the function returns the existing                         *hdc*.  
  
## See Also  
 [ATL Functions](../vs140/atl-functions.md)