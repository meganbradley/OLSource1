---
title: "CAtlAutoThreadModule Class"
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
  - "ATL.CAtlAutoThreadModule"
  - "CAtlAutoThreadModule"
  - "ATL::CAtlAutoThreadModule"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlAutoThreadModule class"
ms.assetid: 3be834aa-55ef-403e-94ae-41979691b15f
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
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
 `CAtlAutoThreadModule` derives from [CAtlAutoThreadModuleT](../VS_csharp/catlautothreadmodulet-class.md) and implements a thread-pooled, apartment-model COM server. `CAtlAutoThreadModule` uses [CComApartment](../VS_csharp/ccomapartment-class.md) to manage an apartment for each thread in the module.  
  
 You must use the [DECLARE_CLASSFACTORY_AUTO_THREAD](../VS_csharp/declare_classfactory_auto_thread.md) macro in your object's class definition to specify [CComClassFactoryAutoThread](../VS_csharp/ccomclassfactoryautothread-class.md) as the class factory. You should then add a single instance of a class derived from `CAtlAutoThreadModuleT` such as `CAtlAutoThreadModule`. For example:  
  
 `CAtlAutoThreadModule _AtlAutoModule; // name is immaterial.`  
  
> [!NOTE]
>  This class replaces the obsolete [CComAutoThreadModule](../VS_csharp/ccomautothreadmodule-class.md) class.  
  
## Inheritance Hierarchy  
 `IAtlAutoThreadModule`  
  
 [CAtlAutoThreadModuleT](../VS_csharp/catlautothreadmodulet-class.md)  
  
 `CAtlAutoThreadModule`  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlAutoThreadModuleT Class](../VS_csharp/catlautothreadmodulet-class.md)   
 [IAtlAutoThreadModule Class](../VS_csharp/iatlautothreadmodule-class.md)   
 [Class Overview](../VS_csharp/atl-class-overview.md)   
 [Module Classes](../VS_csharp/atl-module-classes.md)