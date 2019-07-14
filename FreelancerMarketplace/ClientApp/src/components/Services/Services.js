import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { withRouter } from 'react-router-dom';
import queryString from 'query-string';
import { ServiceListGallery } from './ServiceListGallery/ServiceListGallery';
import AppConfig from '../../appconfig.json';
import './Services.css';

export class Services extends Component {
    constructor(props) {
        super();
        this.state = {
            services: []
        };
    }

    componentDidMount() {
        const values = queryString.parse(this.props.location.search)
        fetch(AppConfig.apiUrl + '/service/' + this.props.categoryId + (values.term != null ? '?term=' + values.term : ""))
            .then(results => {
                return results.json();
            })
            .then(data => {
                let services = data.map((serv) => {
                    let imagePath = `${AppConfig.userImageUrl}/service/${serv.serviceId}/${serv.image}`;
                    return (
                        <React.Fragment key={serv.serviceId}>
                            <ServiceListGallery serviceId={serv.serviceId} imgPath={imagePath} imgName={serv.image} />
                            <div id={serv.serviceId} key={serv.serviceId}>
                                <Link to={{ pathname: `/service-details/${serv.serviceId}` }}>{serv.serviceName}</Link>
                                {/* <div dangerouslySetInnerHTML={{ __html: serv.serviceDescription }} /> */}
                                <p><strong>{serv.publicName}</strong></p>
                                <p>${serv.price} <span style={{ float: 'right' }}>{serv.revisions} days</span></p>
                            </div>
                        </React.Fragment>
                    )
                })
                this.setState({ services: services });
            })
    }

    getServices() {

    }

    componentDidUpdate(prevProps) {
        if (this.props.categoryId !== prevProps.categoryId) {
            fetch(AppConfig.apiUrl + '/service/' + this.props.categoryId)
                .then(results => {
                    return results.json();
                })
                .then(data => {
                    let services = data.map((serv) => {
                        let imagePath = `${AppConfig.userImageUrl}/service/${serv.serviceId}/${serv.image}`;
                        return (
                            <React.Fragment key={serv.serviceId}>
                                <ServiceListGallery serviceId={serv.serviceId} imgPath={imagePath} imgName={serv.image} />
                                <div id={serv.serviceId} key={serv.serviceId}>
                                    <Link to={{ pathname: `/service-details/${serv.serviceId}` }}>{serv.serviceName}</Link>
                                    <p><strong>{serv.publicName}</strong></p>
                                    <p>${serv.price} <span style={{ float: 'right' }}>{serv.revisions} days</span></p>
                                </div>
                            </React.Fragment>
                        )
                    })
                    this.setState({ services: services });
                })
        }
    }

    filterServices() {
        let path = `/explore-services/` + this.props.categoryId + `?term=laurence`;
        this.props.history.push(path);
    }

    //filterServices() {
        //filter only works in array
        //var words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
        //const result = words.filter(word => word.length <= 5);
        //console.log(result);



        //let filteredServices = this.state.services.filter(serv => serv.key === 11)
        //console.log(filteredServices);
        //this.setState({ services: filteredServices });
        

        //let filteredServices = this.state.services
        //filteredServices = filteredServices.filter((serv) => {
        //    return serv.serviceId === 11
        //})
        //this.setState({ services: filteredServices });

        //fetch(AppConfig.apiUrl + '/service/2')
        //    .then(results => {
        //        return results.json();
        //    })
        //    .then(data => {
        //        let services = data.map((serv) => {
        //            let imagePath = `${AppConfig.userImageUrl}/service/${serv.serviceId}/${serv.image}`;
        //            return (
        //                <React.Fragment>
        //                    <ServiceListGallery serviceId={serv.serviceId} imgPath={imagePath} imgName={serv.image} />
        //                    <div id={serv.serviceId} key={serv.serviceId}>
        //                        <Link to={{ pathname: `/service-details/${serv.serviceId}` }}>{serv.serviceName}</Link>
        //                        {/* <div dangerouslySetInnerHTML={{ __html: serv.serviceDescription }} /> */}
        //                        <p><strong>{serv.publicName}</strong></p>
        //                        <p>${serv.price} <span style={{ float: 'right' }}>{serv.revisions} days</span></p>
        //                    </div>
        //                </React.Fragment>
        //            )
        //        })
        //        this.setState({ services: services });
        //    })
    //}

    render() {
        return (
            <React.Fragment>
                <div className="form">
                    <label htmlFor="minPriceFilter">From:</label>
                    <input type="text" id="minPriceFilter" value="{this.state.minPriceFilter}" />
                    <label htmlFor="minPriceFilter">To:</label>
                    <input type="text" id="maxPriceFilter" value="{this.state.maxPriceFilter}" />
                    <button onClick={(e) => { this.filterServices() }}>Search</button>
                </div>
                <div className="container">{this.state.services}</div>
            </React.Fragment>
        );
    }
}

export default withRouter(Services);