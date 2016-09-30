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
  
 [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] determines how many type visualizers and custom viewers are associated with the object's type by calling the [IDebugProperty3::GetCustomViewerCount](../vs140/idebugproperty3--getcustomviewercount.md) method. If there is at least one type visualizer or custom viewer available, Visual Studio calls the [IDebugProperty3::GetCustomViewerList](../vs140/idebugproperty3--getcustomviewerlist.md) method to retrieve a list of those visualizers and viewers (actually, a list of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>s that implement the visualizers and viewers) and presents them to the user.  
  
## Supporting Type Visualizers  
 There are a number of interfaces that the EE must implement to support type visualizers. These interfaces can be broken down into two broad categories: those that list the type visualizers and those that access the property data.  
  
### Listing Type Visualizers  
 The EE supports listing the type visualizers in its implementation of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. These methods pass the call to the corresponding methods [IEEVisualizerService::GetCustomViewerCount](../vs140/ieevisualizerservice--getcustomviewercount.md) and [IEEVisualizerService::GetCustomViewerList](../vs140/ieevisualizerservice--getcustomviewerlist.md).  
  
 The [IEEVisualizerService](../vs140/ieevisualizerservice.md) is obtained by calling [IEEVisualizerServiceProvider::CreateVisualizerService](../vs140/ieevisualizerserviceprovider--createvisualizerservice.md). This method requires the [IDebugBinder3](../vs140/idebugbinder3.md) interface, which is obtained from the [IDebugBinder](../vs140/idebugbinder.md) interface passed to [IDebugParsedExpression::EvaluateSync](../vs140/idebugparsedexpression--evaluatesync.md). <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> also requires the [IDebugSymbolProvider](../vs140/idebugsymbolprovider.md) and [IDebugAddress](../vs140/idebugaddress.md) interfaces which were passed to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The final interface required to create the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface is the [IEEVisualizerDataProvider](../vs140/ieevisualizerdataprovider.md) interface, which the EE implements. This interface allows changes to be made to the property being visualized. All property data is encapsulated in an [IDebugObject](../vs140/idebugobject.md) interface, which is also implemented by the EE.  
  
### Accessing Property Data  
 Accessing property data is done through the [IPropertyProxyEESide](../vs140/ipropertyproxyeeside.md) interface. To obtain this interface, Visual Studio calls [QueryInterface](../vs140/queryinterface.md) on the property object to get the [IPropertyProxyProvider](../vs140/ipropertyproxyprovider.md) interface (implemented on the same object that implements the [IDebugProperty3](../vs140/idebugproperty3.md) interface) and then calls the [IPropertyProxyProvider::GetPropertyProxy](../vs140/ipropertyproxyprovider--getpropertyproxy.md) method to obtain the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> interface.  
  
 All data passed into and out of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface is encapsulated in the [IEEDataStorage](../vs140/ieedatastorage.md) interface. This interface represents an array of bytes and is implemented by both Visual Studio and the EE. When a property's data is to be changed, Visual Studio creates an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object holding the new data and calls [IPropertyProxyEESide::CreateReplacementObject](../vs140/ipropertyproxyeeside--createreplacementobject.md) with that data object in order to obtain a new <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object that, in turn, is passed to [IPropertyProxyEESide::InPlaceUpdateObject](../vs140/ipropertyproxyeeside--inplaceupdateobject.md) to update the property's data. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> allows the EE to instantiate its own class that implements the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface.  
  
## Supporting Custom Viewers  
 The flag <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is set in the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> field of the [DEBUG_PROPERTY_INFO](../vs140/debug_property_info.md) structure (returned by a call to [IDebugProperty2::GetPropertyInfo](../vs140/idebugproperty2--getpropertyinfo.md)) to indicate that the object has a custom viewer associated with it. When this flag is set, Visual Studio obtains the [IDebugProperty3](../vs140/idebugproperty3.md) interface from the [IDebugProperty2](../vs140/idebugproperty2.md) interface using [QueryInterface](../vs140/queryinterface.md).  
  
 If the user selects a custom viewer, Visual Studio instantiates the custom viewer using the viewer's <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> supplied by the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method. Visual Studio then calls [IDebugCustomViewer::DisplayValue](../vs140/idebugcustomviewer--displayvalue.md) to show the value to the user.  
  
 Normally, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> presents a read-only view of the data. To allow changes to the data, the EE must implement a custom interface that supports changing data on a property object. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method uses this custom interface to support changing the data. The method looks for the custom interface on the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface passed in as the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> argument.  
  
## Supporting Both Type Visualizers and Custom Viewers  
 An EE can support both type visualizers and custom viewers in the [IDebugProperty3::GetCustomViewerCount](../vs140/idebugproperty3--getcustomviewercount.md) and [IDebugProperty3::GetCustomViewerList](../vs140/idebugproperty3--getcustomviewerlist.md) methods. First, the EE adds the number of custom viewers that it is supplying to the value returned by the [IEEVisualizerService::GetCustomViewerCount](../vs140/ieevisualizerservice--getcustomviewercount.md) method. Second, the EE appends the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>s of its own custom viewers to the list returned by the [IEEVisualizerService::GetCustomViewerList](../vs140/ieevisualizerservice--getcustomviewerlist.md) method.  
  
## See Also  
 [Debugging Tasks](../vs140/debugging-tasks.md)   
 [Type Visualizer and Custom Viewer](../vs140/type-visualizer-and-custom-viewer.md)