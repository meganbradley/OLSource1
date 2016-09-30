---
title: "&lt;field&gt; (JavaScript)"
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
  - "<field> JavaScript XML tag"
  - "field JavaScript XML tag"
ms.assetid: c494bae0-3095-42a3-aa0a-4c415188c65c
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;field&gt; (JavaScript)
Specifies documentation information, including a description, for either a field or member that's defined on an object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The name of the field or member. When the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element is used in a constructor function, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is required and defines the member to which the tag applies. When the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element is directly annotating a field, this attribute is ignored, and the name used by Visual Studio is the name of the actual field in the source code.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Optional. Specifies whether the field is a member of the constructor function or a member of the object returned by the constructor function. Set to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to treat the field as a member of the constructor function. Set to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to treat the field as a member of the object returned by the constructor function.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Optional. The data type of the field. The type can be one of the following:  
  
-   An ECMAScript language type in the ECMAScript 5 specification, such as <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
-   A DOM object, such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
-   A JavaScript constructor function.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, specifies whether the field is an integer. Set to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> to indicate that the field is an integer; otherwise, set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> attribute takes precedence over this attribute. This attribute specifies whether the documented field is a DOM element. Set to <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to specify that the field is a DOM element; otherwise, set to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, IntelliSense treats the documented field as an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Optional. Specifies whether the documented field can be set to null. Set to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to indicate that the field can be set to null; otherwise, set to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, this attribute specifies the type of the elements in the array.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are integers. Set to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to indicate that the elements in the array are integers; otherwise, set to <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Optional. This attribute is deprecated; the <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> attribute takes precedence over this attribute. If <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, this attribute specifies whether the elements in the array are DOM elements. Set to <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> to specify that the elements are DOM elements; otherwise, set to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> attribute is not set and <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, IntelliSense treats each element in the array as an <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> when performing statement completion.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Optional. If <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, specifies whether the elements in the array can be set to null. Set to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> to indicate that the elements in the array can be set to null; otherwise, set to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. This attribute is not used by Visual Studio to provide IntelliSense information.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Optional. The keyword for F1 help.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 Optional. The identifier for localization information about the field. The identifier is either a member ID or it corresponds to the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../vs140/-loc---javascript-.md) tag.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Optional. Specifies code that should be evaluated for use by IntelliSense instead of the function code itself. For <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, this attribute is supported for constructor functions, but is not supported for object literals. You can use this attribute is to provide type information when the field type is undefined. For example, you can use <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> to treat the field type as a number.  
  
 <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>  
 Optional. A description for the field.  
  
## Remarks  
 The <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> attribute is required when you're documenting a field in a constructor function. For all other scenarios, all attributes for the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> element are optional.  
  
 When you're documenting a constructor function, the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> element must appear immediately before the field declaration. The <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> attribute must match the field name that's used in the source code. For object members, the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> attribute can be omitted if the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> element appears immediately before the object member declaration.  
  
## Example  
 The following code example shows how to use the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> element.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> element with the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> attribute set to <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> element with the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> attribute set to <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> element with the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [XML Documentation Comments](../vs140/xml-documentation-comments--javascript-.md)