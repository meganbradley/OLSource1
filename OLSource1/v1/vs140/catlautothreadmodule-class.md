---
title: "CAtlAutoThreadModule Class"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.CAtlAutoThreadModule
  - CAtlAutoThreadModule
  - ATL::CAtlAutoThreadModule
dev_langs: 
  - C++
helpviewer_keywords: 
  - CAtlAutoThreadModule class
ms.assetid: 3be834aa-55ef-403e-94ae-41979691b15f
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlAutoThreadModule Class
This class implements a thread-pooled, apartment-model COM server.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
```  
  
class CAtlAutoThreadModule :  
   public CAtlAutoThreadModuleT< CAtlAutoThreadModule >  
  
```  
  
## Remarks  
 `CAtlAutoThreadModule` derives from [CAtlAutoThreadModuleT](../vs140/catlautothreadmodulet-class.md) and implements a thread-pooled, apartment-model COM server. `CAtlAutoThreadModule` uses [CComApartment](../vs140/ccomapartment-class.md) to manage an apartment for each thread in the module.  
  
 You must use the [DECLARE_CLASSFACTORY_AUTO_THREAD](../vs140/declare_classfactory_auto_thread.md) macro in your object's class definition to specify [CComClassFactoryAutoThread](../vs140/ccomclassfactoryautothread-class.md) as the class factory. You should then add a single instance of a class derived from `CAtlAutoThreadModuleT` such as `CAtlAutoThreadModule`. For example:  
  
 `CAtlAutoThreadModule _AtlAutoModule; // name is immaterial.`  
  
> [!NOTE]
>  This class replaces the obsolete [CComAutoThreadModule](../vs140/ccomautothreadmodule-class.md) class.  
  
## Inheritance Hierarchy  
 `IAtlAutoThreadModule`  
  
 [CAtlAutoThreadModuleT](../vs140/catlautothreadmodulet-class.md)  
  
 `CAtlAutoThreadModule`  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlAutoThreadModuleT Class](../vs140/catlautothreadmodulet-class.md)   
 [IAtlAutoThreadModule Class](../vs140/iatlautothreadmodule-class.md)   
 [Class Overview](../vs140/atl-class-overview.md)   
 [Module Classes](../vs140/atl-module-classes.md)