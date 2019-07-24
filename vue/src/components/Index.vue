<template>
  <div>
    <h3>组件内容开始</h3>
    <h2>{{ msg }}：{{state}}：{{error}}</h2>
    <h3>组件内容结束</h3>
  </div>
</template>

<script>
export default {
  name: 'IndexContent',
  props: {
    msg: String,
    state :String,
    error : String
  }
}
</script>
