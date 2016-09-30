---
title: "&lt;atomic&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5c53b4f8-6ff5-47d7-beb2-2d6ee3c6ea89
caps.latest.revision: 14
---
# &lt;atomic&gt; functions
||||  
|-|-|-|  
|[atomic_compare_exchange_strong Function](#atomic_compare_exchange_strong_function)|[atomic_compare_exchange_strong_explicit Function](#atomic_compare_exchange_strong_explicit_function)|[atomic_compare_exchange_weak Function](#atomic_compare_exchange_weak_function)|  
|[atomic_compare_exchange_weak_explicit Function](#atomic_compare_exchange_weak_explicit_function)|[atomic_exchange Function](#atomic_exchange_function)|[atomic_exchange_explicit Function](#atomic_exchange_explicit_function)|  
|[atomic_fetch_add Function](#atomic_fetch_add_function)|[atomic_fetch_add_explicit Function](#atomic_fetch_add_explicit_function)|[atomic_fetch_and Function](#atomic_fetch_and_function)|  
|[atomic_fetch_and_explicit Function](#atomic_fetch_and_explicit_function)|[atomic_fetch_or Function](#atomic_fetch_or_function)|[atomic_fetch_or_explicit Function](#atomic_fetch_or_explicit_function)|  
|[atomic_fetch_sub Function](#atomic_fetch_sub_function)|[atomic_fetch_sub_explicit Function](#atomic_fetch_sub_explicit_function)|[atomic_fetch_xor Function](#atomic_fetch_xor_function)|  
|[atomic_fetch_xor_explicit Function](#atomic_fetch_xor_explicit_function)|[atomic_flag_clear Function](#atomic_flag_clear_function)|[atomic_flag_clear_explicit Function](#atomic_flag_clear_explicit_function)|  
|[atomic_flag_test_and_set Function](#atomic_flag_test_and_set_function)|[atomic_flag_test_and_set_explicit Function](#atomic_flag_test_and_set_explicit_function)|[atomic_init Function](#atomic_init_function)|  
|[atomic_is_lock_free Function](#atomic_is_lock_free_function)|[atomic_load Function](#atomic_load_function)|[atomic_load_explicit Function](#atomic_load_explicit_function)|  
|[atomic_signal_fence Function](#atomic_signal_fence_function)|[atomic_store Function](#atomic_store_function)|[atomic_store_explicit Function](#atomic_store_explicit_function)|  
|[atomic_thread_fence Function](#atomic_thread_fence_function)|[kill_dependency Function](#kill_dependency_function)|  
  
##  \<a name="atomic_compare_exchange_strong_function">\</a>  atomic_compare_exchange_strong Function  
 Performs an atomic compare and exchange operation.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 A pointer to a value of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
### Remarks  
 This method performs an atomic compare and exchange operation by using implicit <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum) arguments. For more information, see [atomic_compare_exchange_strong_explicit Function](../vs140/-atomic--functions.md#atomic_compare_exchange_strong_explicit_function).  
  
##  \<a name="atomic_compare_exchange_strong_explicit_function">\</a>  atomic_compare_exchange_strong_explicit Function  
 Performs an *atomic compare and exchange* operation.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A pointer to a value of type <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 First [memory_order](../vs140/-atomic--enums.md#memory_order_enum) argument.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Second <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> argument. The value of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> cannot be <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, it cannot be stronger than the value of <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
### Remarks  
 An *atomic compare and exchange operation* compares the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> against the value that is pointed to by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. If the values are equal, the the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> is replaced with <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> by using a <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> operation and applying the memory order constraints that are specified by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. If the values are not equal, the operation replaces the value that is pointed to by <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> with the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and applies the memory order constraints that are specified by <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_compare_exchange_weak_function">\</a>  atomic_compare_exchange_weak Function  
 Performs a *weak atomic compare and exchange* operation.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>  
 A pointer to a value of type <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
### Remarks  
 This method performs a *weak atomic compare and exchange operation* that has implicit <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum) arguments. For more information, see [atomic_compare_exchange_weak_explicit Function](../vs140/-atomic--functions.md#atomic_compare_exchange_weak_explicit_function).  
  
##  \<a name="atomic_compare_exchange_weak_explicit_function">\</a>  atomic_compare_exchange_weak_explicit Function  
 Performs a *weak atomic compare and exchange* operation.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>  
 A pointer to a value of type <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>  
 First [memory_order](../vs140/-atomic--enums.md#memory_order_enum) argument.  
  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Second <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> argument. The value of <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> cannot be <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>, nor can it be stronger than the value of <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>.  
  
### Return Value  
 A <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> that indicates the result of the value comparison.  
  
### Remarks  
 An *atomic compare and exchange operation* compares the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> with the value that is pointed to by <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. If the values are equal, the operation replaces the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> by using a <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> operation and applying the memory-order constraints that are specified by <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. If the values are not equal, the operation replaces the value that is pointed to by <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> with the value that is stored in the object that is pointed to by <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> and applies the memory-order constraints that are specified by <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.  
  
 A *weak* atomic compare and exchange operation performs an exchange if the compared values are equal. However, if the values are not equal, the operation is not guaranteed to perform an exchange.  
  
##  \<a name="atomic_exchange_function">\</a>  atomic_exchange Function  
 Uses <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> to replace the stored value of <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>.  
  
### Return Value  
 The stored value of <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> before the exchange.  
  
### Remarks  
 The <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>108\</CodeContentPlaceHolder> operation to exchange the value that is stored in <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
##  \<a name="atomic_exchange_explicit_function">\</a>  atomic_exchange_explicit Function  
 Replaces the stored value of <CodeContentPlaceHolder>112\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>113\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>115\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
### Return Value  
 The stored value of <CodeContentPlaceHolder>120\</CodeContentPlaceHolder> before the exchange.  
  
### Remarks  
 The <CodeContentPlaceHolder>121\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>122\</CodeContentPlaceHolder> operation to exchange the value that is stored in <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> with <CodeContentPlaceHolder>124\</CodeContentPlaceHolder>, within the memory constraints that are specified by <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_fetch_add_function">\</a>  atomic_fetch_add Function  
 Adds a value to an existing value that is stored in an <CodeContentPlaceHolder>126\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>128\</CodeContentPlaceHolder> object that stores a pointer to type <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value of the pointer contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>132\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>133\</CodeContentPlaceHolder> operation to atomically add <CodeContentPlaceHolder>134\</CodeContentPlaceHolder> to the stored value in <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraint.  
  
 When the atomic type is <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>138\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>139\</CodeContentPlaceHolder> and the operation treats the stored pointer as a <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>.  
  
 This operation is also overloaded for integral types:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="atomic_fetch_add_explicit_function">\</a>  atomic_fetch_add_explicit Function  
 Adds a value to an existing value that is stored in an <CodeContentPlaceHolder>141\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>142\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>143\</CodeContentPlaceHolder> object that stores a pointer to type <CodeContentPlaceHolder>144\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>145\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>146\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value of the pointer contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> operation to atomically add <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> to the stored value in <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>, within the [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints that are specified by <CodeContentPlaceHolder>151\</CodeContentPlaceHolder>.  
  
 When the atomic type is <CodeContentPlaceHolder>152\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>153\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> and the operation treats the stored pointer as a <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>.  
  
 This operation is also overloaded for integral types:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
##  \<a name="atomic_fetch_and_function">\</a>  atomic_fetch_and Function  
 Performs a bitwise <CodeContentPlaceHolder>156\</CodeContentPlaceHolder> on a value and an existing value that is stored in an <CodeContentPlaceHolder>157\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>164\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>166\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraint.  
  
##  \<a name="atomic_fetch_and_explicit_function">\</a>  atomic_fetch_and_explicit Function  
 Performs a bitwise <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> of a value and an existing value that is stored in an <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>177\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
### Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, within the memory constraints that are specified by <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_fetch_or_function">\</a>  atomic_fetch_or Function  
 Performs a bitwise <CodeContentPlaceHolder>185\</CodeContentPlaceHolder> on a value and an existing value that is stored in an <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>192\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>195\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>196\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
##  \<a name="atomic_fetch_or_explicit_function">\</a>  atomic_fetch_or_explicit Function  
 Performs a bitwise <CodeContentPlaceHolder>199\</CodeContentPlaceHolder> on a value and an existing value that is stored in an <CodeContentPlaceHolder>200\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>203\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>204\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>205\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>206\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
### Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>211\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>212\</CodeContentPlaceHolder>, within the [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints specified by <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_fetch_sub_function">\</a>  atomic_fetch_sub Function  
 Subtracts a value from an existing value that is stored in an <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> object that stores a pointer to type <CodeContentPlaceHolder>217\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value of the pointer contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>221\</CodeContentPlaceHolder> operation to atomically subtract <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> from the stored value in <CodeContentPlaceHolder>223\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>224\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraint.  
  
 When the atomic type is <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> and the operation treats the stored pointer as a <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
 This operation is also overloaded for integral types:  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
##  \<a name="atomic_fetch_sub_explicit_function">\</a>  atomic_fetch_sub_explicit Function  
 Subtracts a value from an existing value that is stored in an <CodeContentPlaceHolder>229\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>230\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>231\</CodeContentPlaceHolder> object that stores a pointer to type <CodeContentPlaceHolder>232\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>233\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>234\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value of the pointer contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>235\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> operation to atomically subtract <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> from the stored value in <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>, within the [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints that are specified by <CodeContentPlaceHolder>239\</CodeContentPlaceHolder>.  
  
 When the atomic type is <CodeContentPlaceHolder>240\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> has type <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> and the operation treats the stored pointer as a <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
 This operation is also overloaded for integral types:  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
##  \<a name="atomic_fetch_xor_function">\</a>  atomic_fetch_xor Function  
 Performs a bitwise <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> on a value and an existing value that is stored in an <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>246\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>248\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>249\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>250\</CodeContentPlaceHolder>.  
  
### Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>251\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>252\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>255\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>256\</CodeContentPlaceHolder>, using the <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
##  \<a name="atomic_fetch_xor_explicit_function">\</a>  atomic_fetch_xor_explicit Function  
 Performs a bitwise <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> on a value and an existing value that is stored in an <CodeContentPlaceHolder>259\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>262\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>263\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>264\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>265\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
### Return Value  
 The value contained by the atomic object immediately before the operation was performed.  
  
### Remarks  
 The <CodeContentPlaceHolder>266\</CodeContentPlaceHolder> function performs a <CodeContentPlaceHolder>267\</CodeContentPlaceHolder> operation to replace the stored value of <CodeContentPlaceHolder>268\</CodeContentPlaceHolder> with a bitwise <CodeContentPlaceHolder>269\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>270\</CodeContentPlaceHolder> and the current value that is stored in <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>, within the [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints that are specified by <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_flag_clear_function">\</a>  atomic_flag_clear Function  
 Sets the <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> flag in an [atomic_flag](../vs140/atomic_flag-structure.md) object to <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>, within the <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>277\</CodeContentPlaceHolder> object.  
  
##  \<a name="atomic_flag_clear_explicit_function">\</a>  atomic_flag_clear_explicit Function  
 Sets the <CodeContentPlaceHolder>278\</CodeContentPlaceHolder> flag in an [atomic_flag](../vs140/atomic_flag-structure.md) object to <CodeContentPlaceHolder>279\</CodeContentPlaceHolder>, within the specified [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>280\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
##  \<a name="atomic_flag_test_and_set_function">\</a>  atomic_flag_test_and_set Function  
 Sets the <CodeContentPlaceHolder>283\</CodeContentPlaceHolder> flag in an [atomic_flag](../vs140/atomic_flag-structure.md) object to <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>, within the constraints of the <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>286\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> object.  
  
### Return Value  
 The initial value of <CodeContentPlaceHolder>288\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_flag_test_and_set_explicit_function">\</a>  atomic_flag_test_and_set_explicit Function  
 Sets the <CodeContentPlaceHolder>289\</CodeContentPlaceHolder> flag in an [atomic_flag](../vs140/atomic_flag-structure.md) object to <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>, within the specified [memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraints.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>292\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
### Return Value  
 The initial value of <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_init_function">\</a>  atomic_init Function  
 Sets the stored value in an <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>296\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>297\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder> is not an atomic operation. It is not thread-safe.  
  
##  \<a name="atomic_is_lock_free_function">\</a>  atomic_is_lock_free Function  
 Specifies whether atomic operations on an <CodeContentPlaceHolder>302\</CodeContentPlaceHolder> object are *lock-free*.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>304\</CodeContentPlaceHolder> object that stores a value of type <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>.  
  
### Return Value  
 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder> if atomic operations on <CodeContentPlaceHolder>307\</CodeContentPlaceHolder> are lock-free; otherwise, <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>.  
  
### Remarks  
 An atomic type is lock-free if no atomic operations on that type use locks. If this function returns true, the type is safe to use in signal-handlers.  
  
##  \<a name="atomic_load_function">\</a>  atomic_load Function  
 Retrieves the stored value in an <CodeContentPlaceHolder>309\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>311\</CodeContentPlaceHolder> object that contains a value of type <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>.  
  
### Return Value  
 The retrieved value that is stored in <CodeContentPlaceHolder>313\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder> implicitly uses the <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
##  \<a name="atomic_load_explicit_function">\</a>  atomic_load_explicit Function  
 Retrieves the stored value in an <CodeContentPlaceHolder>316\</CodeContentPlaceHolder> object, within a specified [memory_order](../vs140/-atomic--enums.md#memory_order_enum).  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>317\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>318\</CodeContentPlaceHolder> object that contains a value of type <CodeContentPlaceHolder>319\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum). Do not use <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>.  
  
### Return Value  
 The retrieved value that is stored in <CodeContentPlaceHolder>323\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_signal_fence_function">\</a>  atomic_signal_fence Function  
 Acts as a *fence*—which is a memory synchronization primitive that enforces ordering between load/store operations—between other fences in a calling thread that have signal handlers that are executed in the same thread.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>  
 A memory ordering constraint that determines fence type.  
  
### Remarks  
 The <CodeContentPlaceHolder>325\</CodeContentPlaceHolder> argument determines fence type.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>326\</CodeContentPlaceHolder>|The fence has no effect.|  
|<CodeContentPlaceHolder>327\</CodeContentPlaceHolder>|The fence is an acquire fence.|  
|<CodeContentPlaceHolder>328\</CodeContentPlaceHolder>|The fence is an acquire fence.|  
|<CodeContentPlaceHolder>329\</CodeContentPlaceHolder>|The fence is a release fence.|  
|<CodeContentPlaceHolder>330\</CodeContentPlaceHolder>|The fence is both an acquire fence and a release fence.|  
|<CodeContentPlaceHolder>331\</CodeContentPlaceHolder>|The fence is both an acquire fence and a release fence, and is sequentially consistent.|  
  
##  \<a name="atomic_store_function">\</a>  atomic_store Function  
 Atomically stores a value in an atomic object.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>332\</CodeContentPlaceHolder>  
 A pointer to an atomic object that contains a value of type <CodeContentPlaceHolder>333\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>334\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>335\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>336\</CodeContentPlaceHolder> stores <CodeContentPlaceHolder>337\</CodeContentPlaceHolder> in the object that is pointed to by <CodeContentPlaceHolder>338\</CodeContentPlaceHolder>, within the <CodeContentPlaceHolder>339\</CodeContentPlaceHolder>[memory_order](../vs140/-atomic--enums.md#memory_order_enum) constraint.  
  
##  \<a name="atomic_store_explicit_function">\</a>  atomic_store_explicit Function  
 Atomically stores a value in an atomic object.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>340\</CodeContentPlaceHolder>  
 A pointer to an <CodeContentPlaceHolder>341\</CodeContentPlaceHolder> object that contains a value of type <CodeContentPlaceHolder>342\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>343\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>344\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>345\</CodeContentPlaceHolder>  
 A [memory_order](../vs140/-atomic--enums.md#memory_order_enum). Do not use <CodeContentPlaceHolder>346\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>347\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>348\</CodeContentPlaceHolder>.  
  
### Remarks  
 <CodeContentPlaceHolder>349\</CodeContentPlaceHolder> stores <CodeContentPlaceHolder>350\</CodeContentPlaceHolder> in the object that is pointed to by <CodeContentPlaceHolder>351\</CodeContentPlaceHolder>, within the <CodeContentPlaceHolder>352\</CodeContentPlaceHolder> that is specified by <CodeContentPlaceHolder>353\</CodeContentPlaceHolder>.  
  
##  \<a name="atomic_thread_fence_function">\</a>  atomic_thread_fence Function  
 Acts as a *fence*—which is a memory synchronization primitive that enforces ordering between load/store operations—without an associated atomic operation.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>354\</CodeContentPlaceHolder>  
 A memory ordering constraint that determines fence type.  
  
### Remarks  
 The <CodeContentPlaceHolder>355\</CodeContentPlaceHolder> argument determines fence type.  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>356\</CodeContentPlaceHolder>|The fence has no effect.|  
|<CodeContentPlaceHolder>357\</CodeContentPlaceHolder>|The fence is an acquire fence.|  
|<CodeContentPlaceHolder>358\</CodeContentPlaceHolder>|The fence is an acquire fence.|  
|<CodeContentPlaceHolder>359\</CodeContentPlaceHolder>|The fence is a release fence.|  
|<CodeContentPlaceHolder>360\</CodeContentPlaceHolder>|The fence is both an acquire fence and a release fence.|  
|<CodeContentPlaceHolder>361\</CodeContentPlaceHolder>|The fence is both an acquire fence and a release fence, and is sequentially consistent.|  
  
##  \<a name="kill_dependency_function">\</a>  kill_dependency Function  
 Removes a dependency.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>362\</CodeContentPlaceHolder>  
 A value of type <CodeContentPlaceHolder>363\</CodeContentPlaceHolder>.  
  
### Return Value  
 The return value is <CodeContentPlaceHolder>364\</CodeContentPlaceHolder>. The evaluation of <CodeContentPlaceHolder>365\</CodeContentPlaceHolder> does not carry a dependency to the function call. By breaking a possible dependency chain, the function might permit the compiler to generate more efficient code.  
  
## See Also  
 [&lt;atomic&gt;](../vs140/-atomic-.md)