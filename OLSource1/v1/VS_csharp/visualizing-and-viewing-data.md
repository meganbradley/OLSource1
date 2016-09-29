---
title: "Visualizing and Viewing Data"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], viewing data"
  - "debugging [Debugging SDK], visualizing data"
ms.assetid: 699dd0f5-7569-40b3-ade6-d0fe53e832bc
caps.latest.revision: 24
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Visualizing and Viewing Data
Type visualizers and custom viewers present data in a way that is quickly meaningful to a developer. The expression evaluator (EE) can support third-party type visualizers as well as supply its own custom viewers.  
  
 [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] determines how many type visualizers and custom viewers are associated with the object's type by calling the [IDebugProperty3::GetCustomViewerCount](../VS_csharp/idebugproperty3--getcustomviewercount.md) method. If there is at least one type visualizer or custom viewer available, Visual Studio calls the [IDebugProperty3::GetCustomViewerList](../VS_csharp/idebugproperty3--getcustomviewerlist.md) method to retrieve a list of those visualizers and viewers (actually, a list of `CLSID`s that implement the visualizers and viewers) and presents them to the user.  
  
## Supporting Type Visualizers  
 There are a number of interfaces that the EE must implement to support type visualizers. These interfaces can be broken down into two broad categories: those that list the type visualizers and those that access the property data.  
  
### Listing Type Visualizers  
 The EE supports listing the type visualizers in its implementation of `IDebugProperty3::GetCustomViewerCount` and `IDebugProperty3::GetCustomViewerList`. These methods pass the call to the corresponding methods [IEEVisualizerService::GetCustomViewerCount](../VS_csharp/ieevisualizerservice--getcustomviewercount.md) and [IEEVisualizerService::GetCustomViewerList](../VS_csharp/ieevisualizerservice--getcustomviewerlist.md).  
  
 The [IEEVisualizerService](../VS_csharp/ieevisualizerservice.md) is obtained by calling [IEEVisualizerServiceProvider::CreateVisualizerService](../VS_csharp/ieevisualizerserviceprovider--createvisualizerservice.md). This method requires the [IDebugBinder3](../VS_csharp/idebugbinder3.md) interface, which is obtained from the [IDebugBinder](../VS_csharp/idebugbinder.md) interface passed to [IDebugParsedExpression::EvaluateSync](../VS_csharp/idebugparsedexpression--evaluatesync.md). `IEEVisualizerServiceProvider::CreateVisualizerService` also requires the [IDebugSymbolProvider](../VS_csharp/idebugsymbolprovider.md) and [IDebugAddress](../VS_csharp/idebugaddress.md) interfaces which were passed to `IDebugParsedExpression::EvaluateSync`. The final interface required to create the `IEEVisualizerService` interface is the [IEEVisualizerDataProvider](../VS_csharp/ieevisualizerdataprovider.md) interface, which the EE implements. This interface allows changes to be made to the property being visualized. All property data is encapsulated in an [IDebugObject](../VS_csharp/idebugobject.md) interface, which is also implemented by the EE.  
  
### Accessing Property Data  
 Accessing property data is done through the [IPropertyProxyEESide](../VS_csharp/ipropertyproxyeeside.md) interface. To obtain this interface, Visual Studio calls [QueryInterface](../VS_csharp/queryinterface.md) on the property object to get the [IPropertyProxyProvider](../VS_csharp/ipropertyproxyprovider.md) interface (implemented on the same object that implements the [IDebugProperty3](../VS_csharp/idebugproperty3.md) interface) and then calls the [IPropertyProxyProvider::GetPropertyProxy](../VS_csharp/ipropertyproxyprovider--getpropertyproxy.md) method to obtain the `IPropertyProxyEESide` interface.  
  
 All data passed into and out of the `IPropertyProxyEESide` interface is encapsulated in the [IEEDataStorage](../VS_csharp/ieedatastorage.md) interface. This interface represents an array of bytes and is implemented by both Visual Studio and the EE. When a property's data is to be changed, Visual Studio creates an `IEEDataStorage` object holding the new data and calls [IPropertyProxyEESide::CreateReplacementObject](../VS_csharp/ipropertyproxyeeside--createreplacementobject.md) with that data object in order to obtain a new `IEEDataStorage` object that, in turn, is passed to [IPropertyProxyEESide::InPlaceUpdateObject](../VS_csharp/ipropertyproxyeeside--inplaceupdateobject.md) to update the property's data. `IPropertyProxyEESide::CreateReplacementObject` allows the EE to instantiate its own class that implements the `IEEDataStorage` interface.  
  
## Supporting Custom Viewers  
 The flag `DBG_ATTRIB_VALUE_CUSTOM_VIEWER` is set in the `dwAttrib` field of the [DEBUG_PROPERTY_INFO](../VS_csharp/debug_property_info.md) structure (returned by a call to [IDebugProperty2::GetPropertyInfo](../VS_csharp/idebugproperty2--getpropertyinfo.md)) to indicate that the object has a custom viewer associated with it. When this flag is set, Visual Studio obtains the [IDebugProperty3](../VS_csharp/idebugproperty3.md) interface from the [IDebugProperty2](../VS_csharp/idebugproperty2.md) interface using [QueryInterface](../VS_csharp/queryinterface.md).  
  
 If the user selects a custom viewer, Visual Studio instantiates the custom viewer using the viewer's `CLSID` supplied by the `IDebugProperty3::GetCustomViewerList` method. Visual Studio then calls [IDebugCustomViewer::DisplayValue](../VS_csharp/idebugcustomviewer--displayvalue.md) to show the value to the user.  
  
 Normally, `IDebugCustomViewer::DisplayValue` presents a read-only view of the data. To allow changes to the data, the EE must implement a custom interface that supports changing data on a property object. The `IDebugCustomViewer::DisplayValue` method uses this custom interface to support changing the data. The method looks for the custom interface on the `IDebugProperty2` interface passed in as the `pDebugProperty` argument.  
  
## Supporting Both Type Visualizers and Custom Viewers  
 An EE can support both type visualizers and custom viewers in the [IDebugProperty3::GetCustomViewerCount](../VS_csharp/idebugproperty3--getcustomviewercount.md) and [IDebugProperty3::GetCustomViewerList](../VS_csharp/idebugproperty3--getcustomviewerlist.md) methods. First, the EE adds the number of custom viewers that it is supplying to the value returned by the [IEEVisualizerService::GetCustomViewerCount](../VS_csharp/ieevisualizerservice--getcustomviewercount.md) method. Second, the EE appends the `CLSID`s of its own custom viewers to the list returned by the [IEEVisualizerService::GetCustomViewerList](../VS_csharp/ieevisualizerservice--getcustomviewerlist.md) method.  
  
## See Also  
 [Debugging Tasks](../VS_csharp/debugging-tasks.md)   
 [Type Visualizer and Custom Viewer](../VS_csharp/type-visualizer-and-custom-viewer.md)