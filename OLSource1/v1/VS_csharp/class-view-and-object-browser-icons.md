---
title: "Class View and Object Browser Icons"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "icons, in Object Browser"
  - "signal icons"
  - "Class View tool, symbols"
  - "graphic symbols"
  - "IntelliSense, icons"
  - "icons, IntelliSense"
  - "symbols, Object Browser icons"
  - "Object Browser, icons in Class View"
ms.assetid: 58cc3f44-c296-4a88-a008-09d28598d9c0
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Class View and Object Browser Icons
**Class View** and the **Object Browser** display icons that represent code entities, for example, namespaces, classes, functions, and variables. The following table illustrates and describes the icons.  
  
|Icon|Description|Icon|Description|  
|----------|-----------------|----------|-----------------|  
|![Namespace Symbol](../VS_csharp/media/vxnamespace_icon.gif "vxNamespace_Icon")|Namespace|![Declaration Symbol](../VS_csharp/media/vxmethod_icon.gif "vxMethod_Icon")|Method or Function|  
|![Class Icon](../VS_csharp/media/vxclass_icon.gif "vxClass_Icon")|Class|![Operator Symbol](../VS_csharp/media/vxoperator_icon.gif "vxOperator_Icon")|Operator|  
|![Lollipop Interface Symbol](../VS_csharp/media/vxinterface_icon.gif "vxInterface_Icon")|Interface|![Property Symbol](../VS_csharp/media/vxproperty_icon.gif "vxProperty_Icon")|Property|  
|![Structure Symbol](../VS_csharp/media/vxstruct_icon.gif "vxStruct_Icon")|Structure|![Field Icon](../VS_csharp/media/vxfield_icon.gif "vxField_Icon")|Field or Variable|  
|![Union Symbol](../VS_csharp/media/vxunion_icon.gif "vxUnion_Icon")|Union|![Event Symbol](../VS_csharp/media/vxevent_icon.gif "vxEvent_Icon")|Event|  
|![Enumeration Symbol](../VS_csharp/media/vxenum_icon.gif "vxEnum_Icon")|Enum|![Constant Icon](../VS_csharp/media/vxconstant_icon.gif "vxConstant_Icon")|Constant|  
|![Type Definition Symbol](../VS_csharp/media/vxtypedef_icon.gif "vxTypeDef_Icon")|TypeDef|![Enumerate Item Symbol](../VS_csharp/media/vxenumitem_icon.gif "vxEnumItem_Icon")|Enum Item|  
|![Visual Studio Module Symbol](../VS_csharp/media/vxmodule_icon.gif "vxModule_Icon")|Module|![Map Item Symbol](../VS_csharp/media/vxmapitem_icon.gif "vxMapItem_Icon")|Map Item|  
|![Extension Method Symbol](../VS_csharp/media/extensionmethod.gif "ExtensionMethod")|Extension Method|![Declaration Symbol](../VS_csharp/media/vxmethod_icon.gif "vxMethod_Icon")|External Declaration|  
|![Delegate Symbol](../VS_csharp/media/vxdelegate_icon.gif "vxDelegate_Icon")|Delegate|![Error Icon for Class View and Object Browser](../VS_csharp/media/erroricon.gif "ErrorIcon")|Error|  
|![Exception Symbol](../VS_csharp/media/vxexception_icon.gif "vxException_Icon")|Exception|![Template Symbol](../VS_csharp/media/vxtemplate_icon.gif "vxTemplate_Icon")|Template|  
|![Map Symbol](../VS_csharp/media/vxmap_icon.gif "vxMap_Icon")|Map|![Error Exclamation Point Symbol](../VS_csharp/media/vxerror_icon.gif "vxError_Icon")|Unknown|  
|![Type Forwarding Symbol](../VS_csharp/media/ob_type_forward.gif "ob_type_forward")|Type Forwarding|||  
  
## Signal Icons  
 The following signal icons apply to all the previous icons and indicate their accessibility.  
  
> [!NOTE]
>  If your project is included in a source control database, additional signal icons may be displayed to indicate source-control status, such as checked in or checked out.  
  
|Icon|Description|  
|----------|-----------------|  
|<No Signal Icon\>|Public. Accessible from anywhere in this component and from any component that references it.|  
|![Signal Protected Symbol](../VS_csharp/media/vxsignal_icon_key.gif "vxSignal_Icon_Key")|Protected. Accessible from the containing class or type, or those derived from the containing class or type.|  
|![Signal Private Symbol](../VS_csharp/media/vxsignal_icon_lock.gif "vxSignal_Icon_Lock")|Private. Accessible only in the containing class or type.|  
|![Signal Sealed Symbol](../VS_csharp/media/vxsignal_icon_envelope.gif "vxSignal_Icon_Envelope")|Sealed.|  
|![Signal Friend&#47;Internal Symbol](../VS_csharp/media/vxsignal_icon_diamond.gif "vxSignal_Icon_Diamond")|Friend/Internal. Accessible only from the project.|  
|![Signal Icon Arrow](../VS_csharp/media/vxsignal_icon_arrow.gif "vxSignal_Icon_Arrow")|Shortcut. A shortcut to the object.|  
  
## See Also  
 [Viewing the Structure of Code](../VS_csharp/viewing-the-structure-of-code.md)