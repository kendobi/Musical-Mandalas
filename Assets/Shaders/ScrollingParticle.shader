// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:0,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:False,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:32724,y:32693,varname:node_4795,prsc:2|emission-9232-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32007,y:32755,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9e029d54302ec40ecae0d99ae156a4c8,ntxv:0,isnm:False|UVIN-5188-UVOUT;n:type:ShaderForge.SFN_Color,id:797,x:32150,y:33172,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_TexCoord,id:8578,x:31388,y:32799,varname:node_8578,prsc:2,uv:0;n:type:ShaderForge.SFN_Multiply,id:4693,x:31551,y:33054,varname:node_4693,prsc:2|A-2999-T,B-1405-OUT;n:type:ShaderForge.SFN_Panner,id:5188,x:31752,y:32869,varname:node_5188,prsc:2,spu:0,spv:1|UVIN-8578-UVOUT,DIST-4693-OUT;n:type:ShaderForge.SFN_Time,id:2999,x:31212,y:33034,varname:node_2999,prsc:2;n:type:ShaderForge.SFN_Tex2d,id:4072,x:31859,y:33071,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_4072,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:efc1047d8403b4a5cbd9611f1448a66f,ntxv:0,isnm:False;n:type:ShaderForge.SFN_ValueProperty,id:1405,x:31361,y:33128,ptovrint:False,ptlb:Speed 1,ptin:_Speed1,varname:node_1405,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.1;n:type:ShaderForge.SFN_Multiply,id:9567,x:32220,y:32822,varname:node_9567,prsc:2|A-6074-A,B-4072-A,C-6074-RGB;n:type:ShaderForge.SFN_Multiply,id:9232,x:32451,y:32809,varname:node_9232,prsc:2|A-9567-OUT,B-2765-OUT;n:type:ShaderForge.SFN_Multiply,id:2765,x:32366,y:33099,varname:node_2765,prsc:2|A-797-RGB,B-1698-RGB;n:type:ShaderForge.SFN_VertexColor,id:1698,x:32129,y:33012,varname:node_1698,prsc:2;proporder:6074-797-4072-1405;pass:END;sub:END;*/

Shader "Mobile/Particles/ScrollingParticle" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _TintColor ("Color", Color) = (1,1,1,1)
        _Alpha ("Alpha", 2D) = "white" {}
        _Speed1 ("Speed 1", Float ) = -0.1
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
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _TintColor;
            uniform sampler2D _Alpha; uniform float4 _Alpha_ST;
            uniform float _Speed1;
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
                float2 node_5188 = (i.uv0+(node_2999.g*_Speed1)*float2(0,1));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_5188, _MainTex));
                float4 _Alpha_var = tex2D(_Alpha,TRANSFORM_TEX(i.uv0, _Alpha));
                float3 emissive = ((_MainTex_var.a*_Alpha_var.a*_MainTex_var.rgb)*(_TintColor.rgb*i.vertexColor.rgb));
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
