import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { ServiceListGallery } from './ServiceListGallery/ServiceListGallery';

export class Services extends Component {
    constructor(props) {
        super();
        this.state = {
            services: []
        };
    }

    componentDidMount() {
        fetch('https://localhost:44394/api/service/' + this.props.categoryId)
            .then(results => {
                return results.json();
            })
            .then(data => {
                let services = data.map((serv) => {
                    let imagePath = `https://localhost:44394/marketplaceassets/service/${ serv.serviceId }/${ serv.image }`;
                    return (
                        <React.Fragment>
                            <ServiceListGallery serviceId={serv.serviceId} imgPath={imagePath} imgName={serv.image} />
                            <div id={serv.serviceId} key={serv.serviceId}>
                                <Link to={{ pathname: `/service-details/${serv.serviceId}` }}>{serv.serviceName}</Link>
                                <div dangerouslySetInnerHTML={{ __html: serv.serviceDescription }} />
                                <p><strong>{serv.publicName}</strong></p>
                                <p>${serv.price} <span style={{ float: 'right' }}>{serv.revisions} days</span></p>
                            </div>
                        </React.Fragment>
                    )
                })
                this.setState({ services: services });
            })
    }

    render() {
        return (
            <div className="container">{this.state.services}</div>
        );
    }
}

export default Services;