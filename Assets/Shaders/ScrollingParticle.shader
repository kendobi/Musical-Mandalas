// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:False,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:32724,y:32693,varname:node_4795,prsc:2|emission-5718-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:31988,y:32534,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9e029d54302ec40ecae0d99ae156a4c8,ntxv:0,isnm:False|UVIN-5188-UVOUT;n:type:ShaderForge.SFN_Multiply,id:2393,x:32198,y:32767,varname:node_2393,prsc:2|A-6074-RGB,B-8375-RGB;n:type:ShaderForge.SFN_Color,id:797,x:32177,y:33257,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Vector1,id:9248,x:32177,y:33417,varname:node_9248,prsc:2,v1:2;n:type:ShaderForge.SFN_Add,id:823,x:31245,y:32117,varname:node_823,prsc:2|A-5334-RGB,B-8578-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8578,x:31042,y:32198,varname:node_8578,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:3570,x:31449,y:32207,varname:node_3570,prsc:2|A-823-OUT,B-2515-OUT;n:type:ShaderForge.SFN_Multiply,id:4693,x:31465,y:32388,varname:node_4693,prsc:2|A-2999-T,B-1405-OUT;n:type:ShaderForge.SFN_VertexColor,id:5334,x:30792,y:32181,varname:node_5334,prsc:2;n:type:ShaderForge.SFN_Panner,id:5188,x:31659,y:32207,varname:node_5188,prsc:2,spu:1,spv:1|UVIN-3570-OUT,DIST-4693-OUT;n:type:ShaderForge.SFN_Time,id:2999,x:31140,y:32362,varname:node_2999,prsc:2;n:type:ShaderForge.SFN_Add,id:8955,x:31295,y:32625,varname:node_8955,prsc:2|A-5334-RGB,B-8243-UVOUT;n:type:ShaderForge.SFN_TexCoord,id:8243,x:31091,y:32654,varname:node_8243,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:6153,x:31504,y:32661,varname:node_6153,prsc:2|A-8955-OUT,B-1932-OUT;n:type:ShaderForge.SFN_Multiply,id:5503,x:31504,y:32795,varname:node_5503,prsc:2|A-309-T,B-9233-OUT;n:type:ShaderForge.SFN_Panner,id:9503,x:31712,y:32661,varname:node_9503,prsc:2,spu:1,spv:1|UVIN-6153-OUT,DIST-5503-OUT;n:type:ShaderForge.SFN_Time,id:309,x:31103,y:32807,varname:node_309,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:8375,x:31959,y:32731,ptovrint:False,ptlb:SecondaryTex,ptin:_SecondaryTex,varname:node_8375,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:4cc62036dc240448c824ed62ee503a98,ntxv:0,isnm:False|UVIN-9503-UVOUT;n:type:ShaderForge.SFN_Multiply,id:5718,x:32463,y:32812,varname:node_5718,prsc:2|A-2393-OUT,B-8510-OUT,C-6517-OUT,D-797-RGB;n:type:ShaderForge.SFN_Multiply,id:8510,x:32198,y:32922,varname:node_8510,prsc:2|A-6074-A,B-8375-A,C-4072-A;n:type:ShaderForge.SFN_Tex2d,id:4072,x:31859,y:33071,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_4072,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:efc1047d8403b4a5cbd9611f1448a66f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:6517,x:32419,y:33186,varname:node_6517,prsc:2|A-5611-A,B-797-A,C-9248-OUT;n:type:ShaderForge.SFN_VertexColor,id:5611,x:32177,y:33107,varname:node_5611,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:1405,x:31282,y:32499,ptovrint:False,ptlb:Speed 1,ptin:_Speed1,varname:node_1405,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.05;n:type:ShaderForge.SFN_ValueProperty,id:9233,x:31272,y:32924,ptovrint:False,ptlb:Speed 2,ptin:_Speed2,varname:node_9233,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Vector1,id:2515,x:31272,y:32343,varname:node_2515,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:1932,x:31321,y:32761,varname:node_1932,prsc:2,v1:0.5;proporder:6074-797-8375-4072-1405-9233;pass:END;sub:END;*/

Shader "Mobile/Particles/ScrollingParticle" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _TintColor ("Color", Color) = (0.5,0.5,0.5,1)
        _Alpha ("Alpha", 2D) = "white" {}
        _Speed1 ("Speed 1", Float ) = 0.05
        _Speed2 ("Speed 2", Float ) = 0.1
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            uniform float4 _TimeEditor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _TintColor;
            uniform sampler2D _Alpha; uniform float4 _Alpha_ST;
            uniform float _Speed1;
            uniform float _Speed2;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_2999 = _Time + _TimeEditor;
                float2 node_5188 = (((i.vertexColor.rgb+float3(i.uv0,0.0))*1.0)+(node_2999.g*_Speed1)*float2(1,1));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_5188, _MainTex));
                float4 node_309 = _Time + _TimeEditor;
                float2 node_9503 = (((i.vertexColor.rgb+float3(i.uv0,0.0))*0.5)+(node_309.g*_Speed2)*float2(1,1));
                float4 _Alpha_var = tex2D(_Alpha,TRANSFORM_TEX(i.uv0, _Alpha));
                float3 emissive = ((_MainTex_var.rgb)*(_MainTex_var.a*_Alpha_var.a)*(i.vertexColor.a*_TintColor.a*2.0)*_TintColor.rgb);
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
