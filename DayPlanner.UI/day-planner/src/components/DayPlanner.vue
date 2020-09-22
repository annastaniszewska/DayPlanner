<template>
    <div>
        <h2>DayPlanner</h2>
        <h3>Today is {{ getCurrentDate() }}</h3>
    </div>
</template>

<script>
import moment from 'moment';
export default {
    name: 'Date',
    moment: moment,
    methods: {
        getCurrentDate: function() {
            return moment().format('DD MMM yyyy');
        }
    }
}
</script>

<style scoped>
h3{
    margin-bottom: 5%;
}
</style>