<template>
        <center id="base" class="">
            <div id="u18" class="ax_default _形状" 
            data-label="Rectangle">
                <p id="u20"><span>登录</span></p>
                 <p id="u27">
                     <input type="text" name="username" lay-verify="title" 
                    autocomplete="off" placeholder="用户名/邮箱" 
                    class="layui-input">
                </p>
                 <p id="u28">
                     <input type="password" name="userpass" lay-verify="title" 
                     autocomplete="off" placeholder="密码" 
                     class="layui-input">
                </p>
                 <p id="u29">
                     <input type="text" name="vcode" lay-verify="title" 
                     autocomplete="off" placeholder="验证码" 
                     class="layui-input">
                </p>
                 <p id="u30">
                    <button type="button" class="layui-btn layui-btn-normal">登录</button>
                </p>
                 <div id="u24" class="ax_default _形状" data-label="Link">
                    <p id="u25"><a href="register">注册新账号</a></p>
                    <p id="u26"><a href="#">忘记密码</a></p>
                </div>
                <img id="u18_img" class="img " src="../assets/images/login/rectangle_u18.png" />
            </div>
        </center>
</template>

<script>
        export default {
            data() {
                return {
                   
                }
            },
            watch: {
            },
            name: 'login',
            components: {
                
            }
        }
    </script>
</script>

<style>
    @import "../assets/files/login/styles.css";
</style>
