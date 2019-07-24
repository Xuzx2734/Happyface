<template>
    <div class="index">
        <h1>这是一个VUE组件:
            <IndexContent msg="坑爹" state="1" error="出错了" />
        </h1>
        <h2>输出一串文字:{{msg}}</h2>
        <h3>对中文对象的支持:{{对象.json对象}}</h3>
        <table border="1">
            <tr>
                <th colspan="4">下面演示:{{对象.标题}}</th>
            </tr>
            <tr>
                <th>序号</th>
                <th>帐号</th>
                <th>年龄</th>
                <th>中文名</th>
            </tr>
            <tr v-for="user in users">
                <td>
                    {{ user.id }}
                </td>
                <td>
                    {{ user.name }}
                </td>
                <td>
                    {{ user.age }}
                </td>
                <td>
                    {{ user.中文名字 }}
                </td>
            </tr>
        </table>
        <h4 v-if="选择器 == 1">
            判断演示：选择器选择了1
        </h4>
        <h4 v-else>
            判断演示：选择器选择非1
        </h4>
        <h4 v-if="选择器 == 0">
            判断演示：选择器选择了0
        </h4>
        <h4 v-else>
            判断演示：选择器选择非0
        </h4>
        <h4>
            选址器的值:{{selectVal}}
        </h4>
        <select id='s1' v-model = "选择器">
            <option value="-1">请选择</option>
            <option value="1">是</option>
            <option value="0">否</option>
        </select>
    </div>
</template>

<script>
    import IndexContent from '@/components/Index.vue'
    export default {
        data() {
            return {
                msg: '这玩意还是很坑爹的',
                对象: {
                    json对象: '对象，中文也可以',
                    标题:'循环'
                },
                users: [{
                    id: '1',
                    name: 'zhousijie',
                    age: '18',
                    中文名字: '周思杰',
                }, {
                    id: '2',
                    name: 'shabi',
                    age: '18',
                    中文名字: '林锐标',
                }, {
                    id: '3',
                    name: 'xzx',
                    age: '18',
                    中文名字: '许子训',
                }, {
                    id: '4',
                    name: 'saohuo',
                    age: '18',
                    中文名字: '彭俊卫',
                }],
                selectVal : "请选择",
                选择器:-1,
            }
        },
        watch: {
            选择器: function(val) {
                this.选择器 = val;
                this.selectVal = val;
            }
        },
        name: 'index',
        components: {
            IndexContent
        }
    }
</script>
