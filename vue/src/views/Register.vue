<template>
    <div id="base" class="">
        <div id="u18" class="ax_default _形状" data-label="Rectangle">
            <img id="u18_img" class="img " src="../assets/images/login/rectangle_u18.png" />
            <p id="u20"><span>注册</span></p>
            <p id="u27">
                <input type="text" name="username" lay-verify="title" autocomplete="off" placeholder="用户名" class="layui-input">
            </p>
            <p id="u28">
                <input type="password" name="userpass" lay-verify="title" autocomplete="off" placeholder="密码" class="layui-input">
            </p>
            <p id="u31">
                <input type="password" name="userpass" lay-verify="title" autocomplete="off" placeholder="再次输入密码" class="layui-input">
            </p>
            <p id="u29">
                <input type="text" name="vcode" lay-verify="title" autocomplete="off" placeholder="验证码" class="layui-input">
            </p>
            <p id="u30">
                <button type="button" class="layui-btn layui-btn-normal">注册</button>
            </p>
            <div id="u24" class="ax_default _形状" data-label="Link">
                <p id="u25"><a href="login">登录</a></p>
                <p id="u26"><a href="#">忘记密码</a></p>
            </div>
        </div>
    </div>
</template>

<script>
    export default {
            data() {
                return {
                   
                }
            },
            watch: {
            },
            name: 'register',
            components: {
                
            }
        }
    </script>
</script>

<style>
    @import "../assets/layui/css/layui.css";
    @import "../assets/files/register/styles.css";
</style>
