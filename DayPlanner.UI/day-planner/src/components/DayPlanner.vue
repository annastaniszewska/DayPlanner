<template>
    <div>
        <h2>DayPlanner</h2>
        <h3>Today is {{ getCurrentDate() }}</h3>
        <div class="col-md-6">
            <p>Plan your day</p>
            <div class="row">
                <div class="col-md-6">
                    <v-text-field outlined label="Add start time:"></v-text-field>
                </div>
                <div class="col-md-6">
                    <v-text-field outlined label="Add end time:"></v-text-field>
                </div>
            </div>
            <button type="submit" class="btn btn-default">Check</button>
        </div>
        <!-- <div>
            {{ info }}
        </div> -->
    </div>
</template>

<script>
import moment from 'moment';
// import axios from 'axios';
export default {
    name: 'Date',
    components: {
    },
    data () {
        return {
            info: null
        }
    },
    // mounted () {
    //     axios
    //         .get('https://localhost:44399/api/Activities/1')
    //         .then(response => (this.info = response))
    // },
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