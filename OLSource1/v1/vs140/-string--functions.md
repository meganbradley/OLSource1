---
title: "&lt;string&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1a4ffd11-dce5-4cc6-a043-b95de034c7c4
caps.latest.revision: 15
---
# &lt;string&gt; functions
||||  
|-|-|-|  
|[getline Template Function](#getline_template_function)|[stod](#stod)|[stof](#stof)|  
|[stoi](#stoi)|[stol](#stol)|[stold](#stold)|  
|[stoll](#stoll)|[stoul](#stoul)|[stoull](#stoull)|  
|[swap](#swap)|[to_string](#to_string)|[to_wstring](#to_wstring)|  
  
##  \<a name="getline_template_function">\</a>  getline Template Function  
 Extract strings from the input stream line-by-line.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The input stream from which a string is to be extracted.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The string into which are read the characters from the input stream.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The line delimiter.  
  
### Return Value  
 The input stream <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>.  
  
### Remarks  
 The pair of function signatures marked <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> extract characters from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> until <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is found, storing them in <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
 The pair of function signatures marked <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> use newline as the default line delimiter and behave as **getline**( <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>(' <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>')).  
  
 The second function of each pair is an analog to the first one to support [rvalue references](../vs140/lvalues-and-rvalues--visual-c---.md).  
  
 Extraction stops when one of the following occurs:  
  
-   At end-of-file, in which case the internal state flag of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
-   After the function extracts an element that compares equal to **delim**, in which case the element is neither put back nor appended to the controlled sequence.  
  
-   After the function extracts <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>[max_size](../vs140/basic_string-class.md#basic_string__max_size) elements, in which case the internal state flag of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
-   Some other error other than those previously listed, in which case the internal state flag of <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 For information about internal state flags, see [ios_base::iostate](../vs140/ios_base-class.md#ios_base__iostate).  
  
 If the function extracts no elements, the internal state flag of <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. In any case, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 If an exception is thrown, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are left in a valid state.  
  
### Example  
  The following code demonstrates <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> in two modes: first with the default delimiter (newline) and second with a whitespace as delimiter. The end-of-file character (CTRL-Z on the keyboard) is used to control termination of the while loops. This sets the internal state flag of <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, which must be cleared with [basic_ios::clear()](../vs140/basic_ios-class.md#basic_ios__clear) before the second while loop will work properly.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="stod">\</a>  stod  
 Converts a character sequence to a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
  
### Return Value  
 The <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>.  
  
##  \<a name="stof">\</a>  stof  
 Converts a character sequence to a float.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
  
### Return Value  
 The float value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>.  
  
##  \<a name="stoi">\</a>  stoi  
 Converts a character sequence to an integer.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The integer value.  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Contains the index of the first unconverted character on return.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|The number base to use.|  
  
### Remarks  
 The function <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> converts the sequence of characters in <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> to a value of type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> and returns the value. For example, when passed a character sequence "10", the value returned by <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> is the integer 10.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> behaves similarly to the function <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> for single-byte characters when it is called in the manner <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> is an object internal to the function; or <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> for wide characters, when it is called in similar manner, <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>. For more information, see [strtol, wcstol, _strtol_l, _wcstol_l](../vs140/strtol--wcstol--_strtol_l--_wcstol_l.md).  
  
 If <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> throws an object of type <CodeContentPlaceHolder>90\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>, or if the returned value cannot be represented as an object of type <CodeContentPlaceHolder>92\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>.  
  
##  \<a name="stol">\</a>  stol  
 Converts a character sequence to a <CodeContentPlaceHolder>97\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|The number base to use.|  
  
### Return Value  
 The long-integer value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>109\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>111\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
##  \<a name="stold">\</a>  stold  
 Converts a character sequence to a <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>115\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>116\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
  
### Return Value  
 The <CodeContentPlaceHolder>117\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>118\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>119\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>127\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>129\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>.  
  
##  \<a name="stoll">\</a>  stoll  
 Converts a character sequence to a <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>132\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>133\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
|<CodeContentPlaceHolder>134\</CodeContentPlaceHolder>|The number base to use.|  
  
### Return Value  
 The <CodeContentPlaceHolder>135\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>136\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>137\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>140\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>148\</CodeContentPlaceHolder>.  
  
##  \<a name="stoul">\</a>  stoul  
 Converts a character sequence to an unsigned long.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>149\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>150\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
|<CodeContentPlaceHolder>151\</CodeContentPlaceHolder>|The number base to use.|  
  
### Return Value  
 The unsigned long-integer value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>159\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>161\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>162\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>.  
  
##  \<a name="stoull">\</a>  stoull  
 Converts a character sequence to an <CodeContentPlaceHolder>165\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>166\</CodeContentPlaceHolder>|The character sequence to be converted.|  
|<CodeContentPlaceHolder>167\</CodeContentPlaceHolder>|The index value of the first unconverted character.|  
|<CodeContentPlaceHolder>168\</CodeContentPlaceHolder>|The number base to use.|  
  
### Return Value  
 The <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> value.  
  
### Remarks  
 The function converts the sequence of elements in <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> to a value <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>172\</CodeContentPlaceHolder> as if by calling <CodeContentPlaceHolder>173\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>174\</CodeContentPlaceHolder> is an object internal to the function. If <CodeContentPlaceHolder>175\</CodeContentPlaceHolder> it throws an object of type <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>. If such a call would set <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>, it throws an object of type <CodeContentPlaceHolder>178\</CodeContentPlaceHolder>. Otherwise, if <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> is not a null pointer, the function stores <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>182\</CodeContentPlaceHolder>.  
  
##  \<a name="swap">\</a>  swap  
 Exchanges the arrays of characters of two strings.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>  
 One string whose elements are to be swapped with those of another string.  
  
 <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
 The other string whose elements are to be swapped with the first string.  
  
### Remarks  
 The template function executes the specialized member function _                        *Left*. [swap](../vs140/basic_string-class.md#basic_string__swap)(\_                        *Right*) for strings, which guarantees constant complexity.  
  
### Example  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  **Before swapping string s1 and s2:**  
**The basic_string s1 = Tweedledee.**  
**The basic_string s2 = Tweedledum.**  
**After swapping string s1 and s2:**  
**The basic_string s1 = Tweedledum.**  
**The basic_string s2 = Tweedledee.**    
##  \<a name="to_string">\</a>  to_string  
 Converts a value to a <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>186\</CodeContentPlaceHolder>|The value to be converted.|  
  
### Return Value  
 The <CodeContentPlaceHolder>187\</CodeContentPlaceHolder> that represents the value.  
  
### Remarks  
 The function converts <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> to a sequence of elements stored in an array object <CodeContentPlaceHolder>189\</CodeContentPlaceHolder> internal to the function as if by calling <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>191\</CodeContentPlaceHolder> is  
  
-   <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>194\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>198\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>201\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>209\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>215\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>216\</CodeContentPlaceHolder>  
  
 The function returns <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>.  
  
##  \<a name="to_wstring">\</a>  to_wstring  
 Converts a value to a wide string.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>218\</CodeContentPlaceHolder>|The value to be converted.|  
  
### Return Value  
 The wide string that represents the value.  
  
### Remarks  
 The function converts <CodeContentPlaceHolder>219\</CodeContentPlaceHolder> to a sequence of elements stored in an array object <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> internal to the function as if by calling <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> is  
  
-   <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>237\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>238\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>243\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>244\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>247\</CodeContentPlaceHolder>  
  
 The function returns <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;string&gt;](../vs140/-string-.md)