---
title: "Annotating Function Parameters and Return Values"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_Outptr_opt_result_bytebuffer_to_"
  - "_Inout_updates_all_opt_"
  - "_Post_equal_to_"
  - "_Outptr_opt_result_maybenull_"
  - "_Out_writes_bytes_all_"
  - "_Out_writes_all_opt_"
  - "_In_opt_"
  - "_Outptr_"
  - "_Outptr_result_maybenull_"
  - "_Outref_result_bytebuffer_all_maybenull_"
  - "_Inout_updates_opt_z_"
  - "_Inout_updates_z_"
  - "_Out_writes_"
  - "_Out_writes_to_ptr_opt_z_"
  - "_In_reads_to_ptr_opt_"
  - "_Ret_writes_to_maybenull_"
  - "_Outref_result_maybenull_"
  - "_Ret_writes_bytes_"
  - "_Outptr_result_bytebuffer_"
  - "_Out_writes_opt_"
  - "_Inout_updates_bytes_opt_"
  - "_In_z_"
  - "_Inout_updates_to_"
  - "_Ret_maybenull_"
  - "_Ret_writes_bytes_to_"
  - "_Ret_z_"
  - "_COM_Outptr_"
  - "_Ret_maybenull_z_"
  - "_Out_opt_"
  - "_In_reads_opt_z_"
  - "_Outptr_result_bytebuffer_to_"
  - "_Ret_notnull_"
  - "_COM_Outptr_opt_result_maybenull_"
  - "_Inout_updates_to_opt_"
  - "_Inout_updates_"
  - "_Outptr_opt_result_buffer_"
  - "_Outptr_result_buffer_to_"
  - "_Out_writes_to_ptr_opt_"
  - "_Out_writes_bytes_all_opt_"
  - "_Inout_updates_all_"
  - "_Deref_inout_range_"
  - "_Ret_writes_"
  - "_Out_writes_z_"
  - "_Ret_writes_to_"
  - "_Out_writes_to_ptr_z_"
  - "_Out_writes_bytes_to_opt_"
  - "_In_reads_or_z_"
  - "_Inout_updates_bytes_to_"
  - "_In_reads_z_"
  - "_In_opt_z_"
  - "_Outref_result_buffer_maybenull_"
  - "_Ret_range_"
  - "_COM_Outptr_opt_"
  - "_Ouptr_opt_result_maybenull_z_"
  - "_In_reads_opt_"
  - "_Inout_"
  - "_Field_range_"
  - "_Ret_writes_z_"
  - "_Out_writes_to_"
  - "_Out_writes_to_ptr_"
  - "_Inout_opt_z_"
  - "_Outref_"
  - "_Deref_out_range_"
  - "_Outref_result_buffer_"
  - "_Outref_result_buffer_to_"
  - "_Outref_result_bytebuffer_to_maybenull_"
  - "_In_reads_bytes_"
  - "_Outptr_opt_result_buffer_to_"
  - "_Outref_result_buffer_all_"
  - "_Out_writes_bytes_to_"
  - "_Result_zeroonfailure_"
  - "_In_reads_bytes_opt_"
  - "_Outref_result_buffer_to_maybenull_"
  - "_Outref_result_bytebuffer_all_"
  - "_Outref_result_buffer_all_maybenull_"
  - "_Ret_writes_maybenull_z_"
  - "_In_range_"
  - "_Inout_updates_bytes_all_opt_"
  - "_Outref_result_bytebuffer_to_"
  - "_Inout_updates_bytes_to_opt_"
  - "_Pre_equal_to_"
  - "_Ret_writes_bytes_maybenull_"
  - "_COM_Outptr_result_maybenull_"
  - "_Ret_writes_maybenull_"
  - "_Out_writes_bytes_"
  - "_Outptr_opt_"
  - "_Out_writes_opt_z_"
  - "_Outref_result_nullonfailure_"
  - "_Outptr_opt_result_z_"
  - "_Inout_opt_"
  - "_Deref_in_range_"
  - "_Outptr_result_z_"
  - "_In_reads_to_ptr_opt_z_"
  - "_Struct_size_bytes_"
  - "_Outptr_result_nullonfailure_"
  - "_In_"
  - "_Inout_updates_bytes_"
  - "_In_reads_to_ptr_z_"
  - "_Ret_writes_bytes_to_maybenull"
  - "_Outptr_opt_result_nullonfailure_"
  - "_In_reads_to_ptr_"
  - "_Outptr_result_buffer_"
  - "_Out_"
  - "_Outref_result_bytebuffer_maybenull_"
  - "_Outptr_result_maybenull_z_"
  - "_In_reads_"
  - "_Inout_updates_opt_"
  - "_Out_writes_to_opt_"
  - "_Outptr_opt_result_bytebuffer_"
  - "_Out_writes_all_"
  - "_Out_range_"
  - "_Inout_updates_bytes_all_"
  - "_Inout_z_"
  - "_Outref_result_bytebuffer_"
  - "_Result_nullonfailure_"
  - "_Ret_null_"
ms.assetid: 82826a3d-0c81-421c-8ffe-4072555dca3a
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Annotating Function Parameters and Return Values
This article describes typical uses of annotations for simple function parameters—scalars, and pointers to structures and classes—and most kinds of buffers.  This article also shows common usage patterns for annotations. For additional annotations that are related to functions, see [Annotating Function Behavior](../vs140/annotating-function-behavior.md)  
  
## Pointer Parameters  
 For the annotations in the following table, when a pointer parameter is being annotated, the analyzer reports an error if the pointer is null.  This applies to pointers and to any data item that's pointed to.  
  
 **Annotations and Descriptions**  
  
-   <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
     Annotates input parameters that are scalars, structures, pointers to structures and the like.  Explicitly may be used on simple scalars.  The parameter must be valid in pre-state and will not be modified.  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
     Annotates output parameters that are scalars, structures, pointers to structures and the like.  Do not apply this to an object that cannot return a value—for example, a scalar that's passed by value.  The parameter does not have to be valid in pre-state but must be valid in post-state.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
     Annotates a parameter that will be changed by the function.  It must be valid in both pre-state and post-state, but is assumed to have different values before and after the call. Must apply to a modifiable value.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     A pointer to a null-terminated string that's used as input.  The string must be valid in pre-state.  Variants of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which already have the correct annotations, are preferred.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
     A pointer to a null-terminated character array that will be modified.  It must be valid before and after the call, but the value is assumed to have changed.  The null terminator may be moved, but only the elements up to the original null terminator may be accessed.  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
     A pointer to an array, which is read by the function.  The array is of size <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> elements, all of which must be valid.  
  
     The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> variant gives the size in bytes instead of elements. Use this only when the size cannot be expressed as elements.  For example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> strings would use the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variant only if a similar function that uses <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> would.  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     A pointer to an array that is null-terminated and has a known size. The elements up to the null terminator—or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if there is no null terminator—must be valid in pre-state.  If the size is known in bytes, scale <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> by the element size.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
     A pointer to an array that is null-terminated or has a known size, or both. The elements up to the null terminator—or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> if there is no null terminator—must be valid in pre-state.  If the size is known in bytes, scale <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> by the element size.  (Used for the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> family.)  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
     A pointer to an array of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements (resp. bytes) that will be written by the function.  The array elements do not have to be valid in pre-state, and the number of elements that are valid in post-state is unspecified.  If there are annotations on the parameter type, they are applied in post-state. For example, consider the following code.  
  
     <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
     In this example, the caller provides a buffer of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> elements for <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> makes some of those elements valid. More importantly, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> annotation on <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> means that <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is null-terminated in post-state.  In this way, the number of valid elements is still well-defined, but a specific element count is not required.  
  
     The <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> variant gives the size in bytes instead of elements. Use this only when the size cannot be expressed as elements.  For example, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> strings would use the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> variant only if a similar function that uses <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> would.  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
     A pointer to an array of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> elements.  The elements do not have to be valid in pre-state.  In post-state, the elements up through the null terminator—which must be present—must be valid.  If the size is known in bytes, scale <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> by the element size.  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
     A pointer to an array, which is both read and written to in the function.  It is of size <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> elements, and valid in pre-state and post-state.  
  
     The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> variant gives the size in bytes instead of elements. Use this only when the size cannot be expressed as elements.  For example, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> strings would use the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> variant only if a similar function that uses <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> would.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
     A pointer to an array that is null-terminated and has a known size. The elements up through the null terminator—which must be present—must be valid in both pre-state and post-state.  The value in the post-state is presumed to be different from the value in the pre-state; this includes the location of the null terminator. If the size is known in bytes, scale <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> by the element size.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
     A pointer to an array of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> elements.  The elements do not have to be valid in pre-state.  In post-state, the elements up to the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>-th element must be valid.  If the size is known in bytes, scale <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> by the element size or use the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> variant, which is defined as:  
  
     <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
     In other words, every element that exists in the buffer up to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> in the pre-state is valid in the post-state.  For example:  
  
     <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
     A pointer to an array, which is both read and written by the function.  It is of size <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> elements, all of which must be valid in pre-state, and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> elements must be valid in post-state.  
  
     The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> variant gives the size in bytes instead of elements. Use this only when the size cannot be expressed as elements.  For example, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> strings would use the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> variant only if a similar function that uses <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> would.  
  
-   <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
  
     A pointer to an array that is null-terminated and has a known size. The elements up through the null terminator—which must be present—must be valid in both pre-state and post-state.  The value in the post-state is presumed to be different from the value in the pre-state; this includes the location of the null terminator. If the size is known in bytes, scale <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> by the element size.  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
  
     A pointer to an array of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> elements.  The elements do not have to be valid in pre-state.  In post-state, the elements up to the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>-th element must be valid.  If the size is known in bytes, scale <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> by the element size or use the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> variant, which is defined as:  
  
     <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>  
  
     In other words, every element that exists in the buffer up to <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> in the pre-state is valid in the post-state.  For example:  
  
     <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>  
  
     A pointer to an array, which is both read and written by the function.  It is of size <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> elements, all of which must be valid in pre-state, and <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> elements must be valid in post-state.  
  
     The <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> variant gives the size in bytes instead of elements. Use this only when the size cannot be expressed as elements.  For example, <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> strings would use the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> variant only if a similar function that uses <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> would.  
  
-   <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
  
     A pointer to an array, which is both read and written by the function of size <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> elements. Defined as equivalent to:  
  
     <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>  
  
     In other words, every element that exists in the buffer up to <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> in the pre-state is valid in the pre-state and post-state.  
  
     The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> variant gives the size in bytes instead of elements. Use this only when the size cannot be expressed as elements.  For example, <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> strings would use the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> variant only if a similar function that uses <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> would.  
  
-   <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>  
  
     A pointer to an array for which the expression <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> (that is, <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> minus <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>) is defined by the appropriate language standard.  The elements prior to <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> must be valid in pre-state.  
  
-   <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>  
  
     A pointer to a null-terminated array for which the expression <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> (that is, <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> minus <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>) is defined by the appropriate language standard.  The elements prior to <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> must be valid in pre-state.  
  
-   <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>  
  
     A pointer to an array for which the expression <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> (that is, <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> minus <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>) is defined by the appropriate language standard.  The elements prior to <CodeContentPlaceHolder>114\</CodeContentPlaceHolder> do not have to be valid in pre-state and must be valid in post-state.  
  
-   <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>  
  
     A pointer to a null-terminated array for which the expression <CodeContentPlaceHolder>116\</CodeContentPlaceHolder> – <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> (that is, <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> minus <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>) is defined by the appropriate language standard.  The elements prior to <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> do not have to be valid in pre-state and must be valid in post-state.  
  
## Optional Pointer Parameters  
 When a pointer parameter annotation includes <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, it indicates that the parameter may be null. Otherwise, the annotation performs the same as the version that doesn't include <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>. Here is a list of the <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> variants of the pointer parameter annotations:  
  
||||  
|-|-|-|  
|<CodeContentPlaceHolder>124\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>141\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>147\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>|  
  
## Output Pointer Parameters  
 Output pointer parameters require special notation to disambiguate null-ness on the parameter and the pointed-to location.  
  
 **Annotations and Descriptions**  
  
-   <CodeContentPlaceHolder>149\</CodeContentPlaceHolder>  
  
     Parameter cannot be null, and in the post-state the pointed-to location cannot be null and must be valid.  
  
-   <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
  
     Parameter may be null, but in the post-state the pointed-to location cannot be null and must be valid.  
  
-   <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>  
  
     Parameter cannot be null, and in the post-state the pointed-to location can be null.  
  
-   <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>  
  
     Parameter may be null, and in the post-state the pointed-to location can be null.  
  
 In the following table, additional substrings are inserted into the annotation name to further qualify the meaning of the annotation.  The various substrings are <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>154\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>.  
  
> [!IMPORTANT]
>  If the interface that you are annotating is COM, use the COM form of these annotations. Do not use the COM annotations with any other type interface.  
  
 **Annotations and Descriptions**  
  
-   <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
  
     The returned pointer has the <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> annotation.  
  
-   <CodeContentPlaceHolder>163\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>  
  
     The returned pointer has COM semantics, and therefore carries an <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> post-condition that the returned pointer is null.  
  
-   <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>170\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>171\</CodeContentPlaceHolder>  
  
     The returned pointer points to a valid buffer of size <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> elements or bytes.  
  
-   <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>  
  
     The returned pointer points to a buffer of size <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> elements or bytes, of which the first <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> are valid.  
  
 Certain interface conventions presume that output parameters are nullified on failure.  Except for explicitly COM code, the forms in the following table are preferred.  For COM code, use the corresponding COM forms that are listed in the previous section.  
  
 **Annotations and Descriptions**  
  
-   <CodeContentPlaceHolder>179\</CodeContentPlaceHolder>  
  
     Modifies other annotations. The result is set to null if the function fails.  
  
-   <CodeContentPlaceHolder>180\</CodeContentPlaceHolder>  
  
     Modifies other annotations. The result is set to zero if the function fails.  
  
-   <CodeContentPlaceHolder>181\</CodeContentPlaceHolder>  
  
     The returned pointer points to a valid buffer if the function succeeds, or null if the function fails. This annotation is for a non-optional parameter.  
  
-   <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>  
  
     The returned pointer points to a valid buffer if the function succeeds, or null if the function fails. This annotation is for an optional parameter.  
  
-   <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
  
     The returned pointer points to a valid buffer if the function succeeds, or null if the function fails. This annotation is for a reference parameter.  
  
## Output Reference Parameters  
 A common use of the reference parameter is for output parameters.  For simple output reference parameters—for example, <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>—<CodeContentPlaceHolder>185\</CodeContentPlaceHolder> provides the correct semantics.  However, when the output value is a pointer—for example <CodeContentPlaceHolder>186\</CodeContentPlaceHolder>—the equivalent pointer annotations like <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> don’t provide the correct semantics.  To concisely express the semantics of output reference parameters for pointer types, use these composite annotations:  
  
 **Annotations and Descriptions**  
  
-   <CodeContentPlaceHolder>188\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null.  
  
-   <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post-state.  
  
-   <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null. Points to valid buffer of size <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> elements.  
  
-   <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null. Points to valid buffer of size <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> bytes.  
  
-   <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null. Points to buffer of <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> elements, of which the first <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> are valid.  
  
-   <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null. Points to buffer of <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> bytes of which the first <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> are valid.  
  
-   <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null. Points to valid buffer of size <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> valid elements.  
  
-   <CodeContentPlaceHolder>202\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state and cannot be null. Points to valid buffer of <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> bytes of valid elements.  
  
-   <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post-state. Points to valid buffer of size <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> elements.  
  
-   <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post-state. Points to valid buffer of size <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> bytes.  
  
-   <CodeContentPlaceHolder>208\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post-state. Points to buffer of <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> elements, of which the first <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> are valid.  
  
-   <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post state. Points to buffer of <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> bytes of which the first <CodeContentPlaceHolder>213\</CodeContentPlaceHolder> are valid.  
  
-   <CodeContentPlaceHolder>214\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post state. Points to valid buffer of size <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> valid elements.  
  
-   <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
  
     Result must be valid in post-state, but may be null in post state. Points to valid buffer of <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> bytes of valid elements.  
  
## Return Values  
 The return value of a function resembles an <CodeContentPlaceHolder>218\</CodeContentPlaceHolder> parameter but is at a different level of de-reference, and you don't have to consider the concept of the pointer to the result.  For the following annotations, the return value is the annotated object—a scalar, a pointer to a struct, or a pointer to a buffer. These annotations have the same semantics as the corresponding <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> annotation.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>220\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>222\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>226\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>227\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>228\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>|  
  
## Other Common Annotations  
 **Annotations and Descriptions**  
  
-   <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>236\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>241\</CodeContentPlaceHolder>  
  
     The parameter, field, or result is in the range (inclusive) from <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  Equivalent to <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> that is applied to the annotated object together with the appropriate pre-state or post-state conditions.  
  
    > [!IMPORTANT]
    >  Although the names contain "in" and "out", the semantics of <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> do **not** apply to these annotations.  
  
-   <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
  
     <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>  
  
     The annotated value is exactly <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>.  Equivalent to <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> that is applied to the annotated object together with the appropriate pre-state or post-state conditions.  
  
-   <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
  
     Applies to a struct or class declaration.  Indicates that a valid object of that type may be larger than the declared type, with the number of bytes being given by <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>.  For example:  
  
     <CodeContentPlaceHolder>253\</CodeContentPlaceHolder>  
  
     The buffer size in bytes of a parameter <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> is then taken to be:  
  
     <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>  
  
## Related Resources  
 [Code Analysis Team Blog](http://go.microsoft.com/fwlink/?LinkId=251197)  
  
## See Also  
 [Using SAL Annotations to Reduce C/C++ Code Defects](../vs140/using-sal-annotations-to-reduce-c-c---code-defects.md)   
 [Understanding SAL](../vs140/understanding-sal.md)   
 [Annotating Function Behavior](../vs140/annotating-function-behavior.md)   
 [Annotating Structs and Classes](../vs140/annotating-structs-and-classes.md)   
 [Annotating Locking Behavior](../vs140/annotating-locking-behavior.md)   
 [Specifying When And Where An Annotation Applies](../vs140/specifying-when-and-where-an-annotation-applies.md)   
 [Intrinsic Functions](../vs140/intrinsic-functions.md)   
 [Best Practices and Examples](../vs140/best-practices-and-examples--sal-.md)