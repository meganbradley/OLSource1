---
title: "accelerator Class"
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
  - "amprt/Concurrency::accelerator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accelerator class"
ms.assetid: 37eed593-cf87-4611-9cdc-e98df6c2377a
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# accelerator Class
An accelerator is a hardware capability that is optimized for data-parallel computing. An accelerator may be a device attached to a PCIe bus (such as a GPU), or it might be an extended instruction set on the main CPU.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator::accelerator Constructor](#accelerator__accelerator_constructor)|Initializes a new instance of the                                         <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> class.|  
|[accelerator::~accelerator Destructor](#accelerator___dtoraccelerator_destructor)|Destroys the                                         <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator::create_view Method](#accelerator__create_view_method)|Creates and returns an                                         <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> object on this accelerator.|  
|[accelerator::get_all Method](#accelerator__get_all_method)|Returns a vector of                                         <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> objects that represent all the available accelerators.|  
|[accelerator::get_auto_selection_view Method](#accelerator__get_auto_selection_view_method)|Returns the auto-selection                                         <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.|  
|[accelerator::get_dedicated_memory Method](#accelerator__get_dedicated_memory_method)|Returns the dedicated memory for the                                         <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, in kilobytes.|  
|[accelerator::get_default_cpu_access_type Method](#accelerator__get_default_cpu_access_type_method)|Returns the default                                         [access_type](concurrency_namespace__c++_amp__Enumerations) for buffers created on this accelerator.|  
|[accelerator::get_default_view Method](#accelerator__get_default_view_method)|Returns the default                                         <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object that is associated with the                                         <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.|  
|[accelerator::get_description Method](#accelerator__get_description_method)|Returns a short description of the                                         <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> device.|  
|[accelerator::get_device_path Method](#accelerator__get_device_path_method)|Returns the path of the device.|  
|[accelerator::get_has_display Method](#accelerator__get_has_display_method)|Determines whether the                                         <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> is attached to a display.|  
|[accelerator::get_is_debug Method](#accelerator__get_is_debug_method)|Determines whether the                                         <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> has the DEBUG layer enabled for extensive error reporting.|  
|[accelerator::get_is_emulated Method](#accelerator__get_is_emulated_method)|Determines whether the                                         <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is emulated.|  
|[accelerator::get_supports_cpu_shared_memory Method](#accelerator__get_supports_cpu_shared_memory_method)|Determines whether the                                         <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> supports shared memory|  
|[accelerator::get_supports_double_precision Method](#accelerator__get_supports_double_precision_method)|Determines whether the                                         <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is attached to a display.|  
|[accelerator::get_supports_limited_double_precision Method](#accelerator__get_supports_limited_double_precision_method)|Determines whether the                                         <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> has limited support for double-precision math.|  
|[accelerator::get_version Method](#accelerator__get_version_method)|Returns the version of the                                         <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.|  
|[accelerator::set_default Method](#accelerator__set_default_method)|Returns the path of the default accelerator.|  
|[Accelerator::set_default_cpu_access_type Method](#accelerator__set_default_cpu_access_type_method)|Sets the default CPU                                         [access_type](concurrency_namespace__c++_amp__Enumerations) for arrays and implicit memory allocations made on this                                         <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator::operator!= Operator](#accelerator__operator_neq_operator)|Compares this                                         <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object with another and returns                                         <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> if they are the same; otherwise, returns                                         <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>.|  
|[accelerator::operator= Operator](#accelerator__operator_eq_operator)|Copies the contents of the specified                                         <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> object to this one.|  
|[accelerator::operator== Operator](#accelerator__operator_eq_eq_operator)|Compares this                                         <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> object with another and returns                                         <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> if they are the same; otherwise, returns                                         <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[accelerator::cpu_accelerator Data Member](#accelerator__cpu_accelerator_data_member)|Gets a string constant for the CPU                                         <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.|  
|[accelerator::dedicated_memory Data Member](#accelerator__dedicated_memory_data_member)|Gets the dedicated memory for the                                         <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>, in kilobytes.|  
|[accelerator::default_accelerator Data Member](#accelerator__default_accelerator_data_member)|Gets a string constant for the default                                         <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>.|  
|[accelerator::default_cpu_access_type Data Member](#accelerator__default_cpu_access_type_data_member)|Gets or sets the default CPU                                         [access_type](concurrency_namespace__c++_amp__Enumerations) for arrays and implicit memory allocations made on this                                         <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>.|  
|[accelerator::default_view Data Member](#accelerator__default_view_data_member)|Gets the default                                         <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> object that is associated with the                                         <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>.|  
|[accelerator::description Data Member](#accelerator__description_data_member)|Gets a short description of the                                         <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> device.|  
|[accelerator::device_path Data Member](#accelerator__device_path_data_member)|Gets the path of the device.|  
|[accelerator::direct3d_ref Data Member](#accelerator__direct3d_ref_data_member)|Gets a string constant for a Direct3D reference                                         <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.|  
|[accelerator::direct3d_warp Data Member](#accelerator__direct3d_warp_data_member)|Gets the string constant for an                                         [accelerator](../vs140/accelerator-class.md) object that you can use for executing C++ AMP code on multi-core CPUs that use Streaming SIMD Extensions (SSE).|  
|[accelerator::has_display Data Member](#accelerator__has_display_data_member)|Gets a Boolean value that indicates whether the                                         <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> is attached to a display.|  
|[accelerator::is_debug Data Member](#accelerator__is_debug_data_member)|Indicates whether the                                         <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> has the DEBUG layer enabled for extensive error reporting.|  
|[accelerator::is_emulated Data Member](#accelerator__is_emulated_data_member)|Indicates whether the                                         <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> is emulated.|  
|[Accelerator::supports_cpu_shared_memory Data Member](#accelerator__supports_cpu_shared_memory_data_member)|Indicates whether the                                         <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> supports shared memory.|  
|[accelerator::supports_double_precision Data Member](#accelerator__supports_double_precision_data_member)|Indicates whether the accelerator supports double-precision math.|  
|[accelerator::supports_limited_double_precision Data Member](#accelerator__supports_limited_double_precision_data_member)|Indicates whether the accelerator has limited support for double-precision math.|  
|[accelerator::version Data Member](#accelerator__version_data_member)|Gets the version of the                                         <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>.|  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>  
  
## Remarks  
 An accelerator is a hardware capability that is optimized for data-parallel computing. An accelerator is often a discrete GPU, but it can also be a virtual host-side entity such as a DirectX REF device, a WARP (a CPU-side device that is accelerated by means of SSE instructions), or the CPU itself.  
  
 You can construct an                 <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object by enumerating the available devices, or by getting the default device, the reference device, or the WARP device.  
  
## Requirements  
 **Header:** amprt.h  
  
 **Namespace:** Concurrency  
  
##  \<a name="accelerator___dtoraccelerator_destructor">\</a>  accelerator::~accelerator Destructor  
 Destroys the                 [accelerator](../vs140/accelerator-class.md) object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
  
##  \<a name="accelerator__accelerator_constructor">\</a>  accelerator::accelerator Constructor  
 Initializes a new instance of the                 [accelerator class](../vs140/accelerator-class.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>  
 The path of the physical device.  
  
 <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
 The accelerator to copy.  
  
##  \<a name="accelerator__cpu_accelerator_data_member">\</a>  accelerator::cpu_accelerator Data Member  
 Gets a string constant for the CPU accelerator.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="accelerator__create_view_method">\</a>  accelerator::create_view Method  
 Creates and returns an                 <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> object on this accelerator, using the specified queuing mode. When the queuing mode is not specified, the new                 <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> uses the                 [queuing_mode::immediate](concurrency_namespace__c++_amp__Enumerations) queuing mode.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>  
 The queuing mode.  
  
### Return Value  
 A new                         <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> object on this accelerator, using the specified queuing mode.  
  
##  \<a name="accelerator__dedicated_memory_data_member">\</a>  accelerator::dedicated_memory Data Member  
 Gets the dedicated memory for the                 [accelerator](../vs140/accelerator-class.md), in kilobytes.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="accelerator__default_accelerator_data_member">\</a>  accelerator::default_accelerator Data Member  
 Gets a string constant for the default                 [accelerator](../vs140/accelerator-class.md).  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="accelerator__default_cpu_access_type_data_member">\</a>  accelerator::default_cpu_access_type Data Member  
 The default cpu                 [access_type](concurrency_namespace__c++_amp__Enumerations) for arrays and implicit memory allocations made on this this                 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="accelerator__default_view_data_member">\</a>  accelerator::default_view Data Member  
 Gets the default accelerator view that is associated with the                 [accelerator](../vs140/accelerator-class.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="accelerator__description_data_member">\</a>  accelerator::description Data Member  
 Gets a short description of the                 [accelerator](../vs140/accelerator-class.md) device.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="accelerator__device_path_data_member">\</a>  accelerator::device_path Data Member  
 Gets the path of the accelerator. The path is unique on the system.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
##  \<a name="accelerator__direct3d_ref_data_member">\</a>  accelerator::direct3d_ref Data Member  
 Gets a string constant for a Direct3D reference accelerator.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
##  \<a name="accelerator__direct3d_warp_data_member">\</a>  accelerator::direct3d_warp Data Member  
 Gets the string constant for an                 [accelerator](../vs140/accelerator-class.md) object that you can use for executing your C++ AMP code on multi-core CPUs using Streaming SIMD Extensions (SSE).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="accelerator__get_all_method">\</a>  accelerator::get_all Method  
 Returns a vector of                 <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> objects that represent all the available accelerators.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 The vector of available accelerators  
  
##  \<a name="accelerator__get_auto_selection_view_method">\</a>  accelerator::get_auto_selection_view Method  
 Returns the auto selection accelerator_view, which when specified as the parallel_for_each target results in the target accelerator_view for executing the parallel_for_each kernel to be automatically selected by the runtime. For all other purposes, the accelerator_view returned by this method is the same as the default accelerator_view of the default accelerator  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Return Value  
 The auto selection accelerator_view.  
  
##  \<a name="accelerator__get_dedicated_memory_method">\</a>  accelerator::get_dedicated_memory Method  
 Returns the dedicated memory for the                 [accelerator](../vs140/accelerator-class.md), in kilobytes.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 The dedicated memory for the                         <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, in kilobytes.  
  
##  \<a name="accelerator__get_default_cpu_access_type_method">\</a>  accelerator::get_default_cpu_access_type Method  
 Gets the default cpu access_type for buffers created on this accelerator  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Return Value  
 The default cpu access_type for buffers created on this accelerator.  
  
##  \<a name="accelerator__get_default_view_method">\</a>  accelerator::get_default_view Method  
 Returns the default                 <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> object that is associated with the                 [accelerator](../vs140/accelerator-class.md).  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 The default                         <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object that is associated with the                         <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_description_method">\</a>  accelerator::get_description Method  
 Returns a short description of the                 [accelerator](../vs140/accelerator-class.md) device.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Return Value  
 A short description of the                         <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> device.  
  
##  \<a name="accelerator__get_device_path_method">\</a>  accelerator::get_device_path Method  
 Returns the path of the accelerator. The path is unique on the system.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Return Value  
 The system-wide unique device instance path.  
  
##  \<a name="accelerator__get_has_display_method">\</a>  accelerator::get_has_display Method  
 Returns a Boolean value that indicates whether the                 [accelerator](../vs140/accelerator-class.md) can output to a display.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> if the                         <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> can output to a display; otherwise,                         <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_is_debug_method">\</a>  accelerator::get_is_debug Method  
 Determines whether the                 [accelerator](../vs140/accelerator-class.md) has the DEBUG layer enabled for extensive error reporting.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> if the                         <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> has the DEBUG layer enabled for extensive error reporting. Otherwise,                         <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_is_emulated_method">\</a>  accelerator::get_is_emulated Method  
 Determines whether the                 [accelerator](../vs140/accelerator-class.md) is emulated.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> if the                         <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> is emulated. Otherwise,                         <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_supports_cpu_shared_memory_method">\</a>  accelerator::get_supports_cpu_shared_memory Method  
 Returns a boolean value indicating whether the accelerator supports memory accessible both by the accelerator and the CPU.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> if the accelerator supports CPU shared memory; otherwise,                         <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_supports_double_precision_method">\</a>  accelerator::get_supports_double_precision Method  
 Returns a Boolean value that indicates whether the accelerator supports double precision math, including fused multiply add (FMA), division, reciprocal, and casting between                 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> if the accelerator supports double precision math; otherwise,                         <CodeContentPlaceHolder>123\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_supports_limited_double_precision_method">\</a>  accelerator::get_supports_limited_double_precision Method  
 Returns a Boolean value that indicates whether the accelerator has limited support for double precision math. If the accelerator has only limited support, then fused multiply add (FMA), division, reciprocal, and casting between                 <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder> are not supported.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> if the accelerator has limited support for double precision math; otherwise,                         <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__get_version_method">\</a>  accelerator::get_version Method  
 Returns the version of the                 [accelerator](../vs140/accelerator-class.md).  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 The version of the                         <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__has_display_data_member">\</a>  accelerator::has_display Data Member  
 Gets a Boolean value that indicates whether the                 [accelerator](../vs140/accelerator-class.md) can output to a display.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
##  \<a name="accelerator__is_debug_data_member">\</a>  accelerator::is_debug Data Member  
 Gets a Boolean value that indicates whether the                 [accelerator](../vs140/accelerator-class.md) has the DEBUG layer enabled for extensive error reporting.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
##  \<a name="accelerator__is_emulated_data_member">\</a>  accelerator::is_emulated Data Member  
 Gets a Boolean value that indicates whether the                 [accelerator](../vs140/accelerator-class.md) is emulated.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
##  \<a name="accelerator__operator_neq_operator">\</a>  accelerator::operator!= Operator  
 Compares this                 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> object with another and returns                 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder> if they are the same; otherwise, returns                 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> object to compare with this one.  
  
### Return Value  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> if the two                         <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> objects are the same; otherwise,                         <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__operator_eq_operator">\</a>  accelerator::operator= Operator  
 Copies the contents of the specified                 [accelerator](../vs140/accelerator-class.md) object to this one.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> object to copy from.  
  
### Return Value  
 A reference to this                         <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> object.  
  
##  \<a name="accelerator__operator_eq_eq_operator">\</a>  accelerator::operator== Operator  
 Compares this                 [accelerator](../vs140/accelerator-class.md) object with another and returns                 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> if they are the same; otherwise, returns                 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object to compare with this one.  
  
### Return Value  
 <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> if the other                         <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> object is same as this                         <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> object; otherwise,                         <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__set_default_method">\</a>  accelerator::set_default Method  
 Sets the default accelerator to be used for any operation that implicitly uses the default accelerator. This method only succeeds if the runtime selected default accelerator has not already been used in an operation that implicitly uses the default accelerator  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>  
 The path to the accelerator.  
  
### Return Value  
 <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> if the call succeeds at setting the default accelerator. Otherwise,                         <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator__set_default_cpu_access_type_method">\</a>  accelerator::set_default_cpu_access_type Method  
 Set the default cpu access_type for arrays created on this accelerator or for implicit memory allocations as part of array_views accessed on this this accelerator. This method only succeeds if the default_cpu_access_type for the accelerator has not already been overriden by a previous call to this method and the runtime selected default_cpu_access_type for this accelerator has not yet been used for allocating an array or for an implicit memory allocation backing an array_view accessed on this accelerator.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
 The default cpu access_type to be used for array/array_view memory allocations on this accelerator.  
  
### Return Value  
 A boolean value indicating if the default cpu access_type for the accelerator was successfully set.  
  
##  \<a name="accelerator__supports_cpu_shared_memory_data_member">\</a>  accelerator::supports_cpu_shared_memory Data Member  
 Gets a Boolean value indicating whether the                 <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> supports shared memory.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
##  \<a name="accelerator__supports_double_precision_data_member">\</a>  accelerator::supports_double_precision Data Member  
 Gets a Boolean value that indicates whether the accelerator supports double precision math.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
##  \<a name="accelerator__supports_limited_double_precision_data_member">\</a>  accelerator::supports_limited_double_precision Data Member  
 Gets a Boolean value that indicates whether the accelerator has limited support for double precision math. If the accelerator has only limited support, then fused multiply add (FMA), division, reciprocal, and casting between                 <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> and                 <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> are not supported.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
##  \<a name="accelerator__version_data_member">\</a>  accelerator::version Data Member  
 Gets the version of the                 [accelerator](../vs140/accelerator-class.md).  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
##  \<a name="accelerator_view___dtoraccelerator_view_destructor">\</a>  accelerator_view::~accelerator_view Destructor  
 Destroys the                  [accelerator_view](../vs140/accelerator_view-class.md) object.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Return Value  
  
##  \<a name="accelerator_view__accelerator_data_member">\</a>  accelerator_view::accelerator Data Member  
 Gets the                  [accelerator](../vs140/accelerator-class.md) object for the                  [accelerator_view](../vs140/accelerator_view-class.md) object.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
##  \<a name="accelerator_view__accelerator_view_constructor">\</a>  accelerator_view::accelerator_view Constructor  
 Initializes a new instance of the                 [accelerator_view](../vs140/accelerator_view-class.md) class by copying an existing                 <CodeContentPlaceHolder>155\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object to copy.  
  
##  \<a name="accelerator_view__create_marker_method">\</a>  accelerator_view::create_marker Method  
 Returns a future to track the completion of all commands submitted so far to this                 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 A future to track the completion of all commands submitted so far to this                         <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object.  
  
##  \<a name="accelerator_view__flush_method">\</a>  accelerator_view::flush Method  
 Submits all pending commands queued to the                 [accelerator_view](../vs140/accelerator_view-class.md) object to the accelerator for execution.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Return Value  
 Returns                         <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator_view__get_accelerator_method">\</a>  accelerator_view::get_accelerator Method  
 Returns the                 [accelerator](../vs140/accelerator-class.md) object for the                  [accelerator_view](../vs140/accelerator_view-class.md) object.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Return Value  
 The                         <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> object for the                         <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> object.  
  
##  \<a name="accelerator_view__get_is_auto_selection_method">\</a>  accelerator_view::get_is_auto_selection Method  
 Returns a Boolean value that indicates whether the runtime will automatically select an appropriate accelerator when the accelerator_view is passed to a                 [parallel_for_each](concurrency_namespace__c++_amp__Functions).  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> if the runtime will automatically select an appropriate accelerator; otherwise,                         <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator_view__get_is_debug_method">\</a>  accelerator_view::get_is_debug Method  
 Returns a Boolean value that indicates whether the                 [accelerator_view](../vs140/accelerator_view-class.md) object has the DEBUG layer enabled for extensive error reporting.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Return Value  
 A Boolean value that indicates whether the                         <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> object has the DEBUG layer enabled for extensive error reporting.  
  
##  \<a name="accelerator_view__get_queuing_mode_method">\</a>  accelerator_view::get_queuing_mode Method  
 Returns the queuing mode for the                 [accelerator_view](../vs140/accelerator_view-class.md) object.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Return Value  
 The queuing mode for the                         <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> object.  
  
##  \<a name="accelerator_view__get_version_method">\</a>  accelerator_view::get_version Method  
 Returns the version of the                 [accelerator_view](../vs140/accelerator_view-class.md).  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Return Value  
 The version of the                         <CodeContentPlaceHolder>167\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator_view__is_auto_selection_data_member">\</a>  accelerator_view::is_auto_selection Data Member  
 Gets a Boolean value that indicates whether the runtime will automatically select an appropriate accelerator when the accelerator_view is passed to a                 [parallel_for_each](concurrency_namespace__c++_amp__Functions).  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
##  \<a name="accelerator_view__is_debug_data_member">\</a>  accelerator_view::is_debug Data Member  
 Gets a Boolean value that indicates whether the                 [accelerator_view](../vs140/accelerator_view-class.md) object has the  DEBUG layer enabled for extensive error reporting.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
##  \<a name="accelerator_view__operator_neq_operator">\</a>  accelerator_view::operator!= Operator  
 Compares this                 [accelerator_view](../vs140/accelerator_view-class.md) object with another and returns                 <CodeContentPlaceHolder>168\</CodeContentPlaceHolder> if they are the same; otherwise, returns                 <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> object to compare with this one.  
  
### Return Value  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> if the two objects are the same; otherwise,                         <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator_view__operator_eq_operator">\</a>  accelerator_view::operator= Operator  
 Copies the contents of the specified                  [accelerator_view](../vs140/accelerator_view-class.md) object into this one.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> object to copy from.  
  
### Return Value  
 A reference to the modified                         <CodeContentPlaceHolder>176\</CodeContentPlaceHolder> object.  
  
##  \<a name="accelerator_view__operator_eq_eq_operator">\</a>  accelerator_view::operator== Operator  
 Compares this                 [accelerator_view](../vs140/accelerator_view-class.md) object with another and returns                 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> if they are the same; otherwise, returns                 <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
 The                                 <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> object to compare with this one.  
  
### Return Value  
 <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> if the two objects are the same; otherwise,                         <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
##  \<a name="accelerator_view__queuing_mode_data_member">\</a>  accelerator_view::queuing_mode Data Member  
 Gets the queuing mode for the                  [accelerator_view](../vs140/accelerator_view-class.md) object.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
##  \<a name="accelerator_view__version_data_member">\</a>  accelerator_view::version Data Member  
 Gets the version of the                 [accelerator_view](../vs140/accelerator_view-class.md).  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
##  \<a name="accelerator_view__wait_method">\</a>  accelerator_view::wait Method  
 Waits for all commands submitted to the                  [accelerator_view](../vs140/accelerator_view-class.md) object to finish.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Return Value  
 Returns                         <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>.  
  
## See Also  
 [Concurrency Namespace (C++ Accelerated Massive Parallelism)](../vs140/concurrency-namespace--c---amp-.md)