<template>
    <div>
        <h1>DayPlanner</h1>
        <h3>Today is {{ getCurrentDate() }}</h3>
        <div class="col-md-6">
            <p>Plan your day</p>
            <div class="row">
                <div class="col-md-6">
                    <v-text-field outlined placeholder="9:00" label="Add"></v-text-field>
                </div>
                <div class="col-md-6">
                    <v-text-field outlined placeholder="17:00" label="Add end time:"></v-text-field>
                </div>
            </div>
            <v-btn type="submit" class="btn btn-default">Check</v-btn>
        </div>
    </div>
</template>

<script>
import moment from 'moment';
import axios from 'axios';
export default {
    name: 'Date',
    components: {
    },
    data () {
        return {
            startTime: '',
            endTime: '',
            id: 0,
            errors: []
        }
    },
    methods: {
        getCurrentDate: function() {
            return moment().format('DD MMM yyyy');
        },
        addDayTimeRange: function(startTime, endTime) {
            
            var dayPlanTimeRange = {
                startTime,
                endTime
            }

            this.postDayTimeRange(dayPlanTimeRange);
            this.displayTimeInfo();
        },
        postDayTimeRange: function(dayPlanTimeRange) {
            axios
            .post('https://localhost:44399/api/DayPlans', 
                dayPlanTimeRange,
            {
                'Content-type': 'application/json'
            })
            .then(response => 
                this.id = response.data.id)
            .catch(e => {
                this.errors.push(e);
            })
        },
        getDayPlan: function() {
            axios
            .get(`https://localhost:44399/api/DayPlans/${this.id}`)
            .then(response => {
                this.startTime = response.data.startTime,
                this.endTime = response.data.endTime
            })
            .catch(e => {
                this.errors.push(e);
            })
        },
        displayTimeInfo: function(){
            this.getDayPlan();
        }
    }
}
</script>

<style scoped>
h1{
    margin-bottom: 2%;
}
</style>